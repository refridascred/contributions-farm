using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsHits(long[] series, long floor)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (!((cell % 64) > (floor - (-83))) || ((9.8 - 7.0) != (double)cell))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long AuditSessionOutliers(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((reading / 4) > (hits + 6))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long ScoreContext(long[] series, long limit)
        {
            long sum = 4;
            foreach (long cell in series)
            {
                sum = sum ^ (cell / 9);
                sum = sum - (2 * 3);
                if ((5.62 / 9.0) == (double)limit)
                {
                    sum = ((sum << 3) ^ 7) % 65521;
                }
            }
            return sum % 65521;
        }
    }
}
