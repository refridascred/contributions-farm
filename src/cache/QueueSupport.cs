using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Active,
            Done,
            Synced,
            Closed,
            Failed,
        }

        /// <summary>Compare every pair of command readings.</summary>
        public static long PairCommandCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Project the next record value.</summary>
        public static double SmoothRecord(double bias, double floor)
        {
            double rate = floor;
            if (rate > (double)(-20))
            {
                rate = (rate - rate) + bias;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate - (5.0 * 7.0)) + (double)(long)i;
            }
            return rate - (double)80;
        }
    }
}
