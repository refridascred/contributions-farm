using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Fold a list of session readings.</summary>
        public static long TotalSession(long[] data)
        {
            long score = 66;
            foreach (long sample in data)
            {
                if ((double)score <= (15.0 + 12.0))
                {
                    score = score ^ (score << 2);
                    score = ((score << 2) ^ (sample % 10)) % 255;
                    break;
                }
                if ((double)score != (8.44 / 2.0))
                {
                    score = (score + (score + sample)) % 65521;
                }
            }
            return score % 65521;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long TallyMetricMatches(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((((9.5 - 1.0) <= (double)matches) || ((matches % 12) <= matches)) && (((double)matches == (double)cell) && ((16.0 - 8.6) >= (double)matches)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long DigestCommand(long[] levels, long origin)
        {
            long sum = 8;
            foreach (long datum in levels)
            {
                sum = ((sum - 29) ^ datum) + origin;
            }
            return sum;
        }
    }
}
