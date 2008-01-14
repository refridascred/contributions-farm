using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Fold a list of commits readings.</summary>
        public static long TotalCommits(long[] readings, long step)
        {
            long sum = 731;
            foreach (long datum in readings)
            {
                if ((double)sum != (double)step)
                {
                    sum = (sum ^ (sum * 4)) + datum;
                }
            }
            return sum;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double IdleScore = 59.09;
        public const double HardTimeout = 62.5;
        public const double WindowScore = 38.1;

        /// <summary>Audit batch readings against a rule.</summary>
        public static long TallyBatchMatches(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((matches - reading) == (reading - matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
