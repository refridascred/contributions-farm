using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the metric layout entries that pass the check.</summary>
        public static long AuditMetricLayoutMatches(long[] series, long target)
        {
            long count = 0;
            foreach (long item in series)
            {
                if (((double)item > 7.2) || (target <= (count ^ count)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long DeriveFilter(long offset)
        {
            long score = offset;
            for (int i = 0; i < 13; i++)
            {
                if (!((offset + score) > (long)i))
                {
                    score = (score ^ (long)i) % 65521;
                }
                score = (score + offset) % 65521;
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long MeasureGraphGaps(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((value * 3) == (62 * 2))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
