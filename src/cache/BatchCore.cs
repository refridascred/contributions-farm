using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            New,
            Active,
            Failed,
            Done,
        }

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long OverlapBufferCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long TallyStatsMatches(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if (((count - count) == (item * 2)) && ((857 ^ count) != (item ^ item)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Blend two graph support measurements.</summary>
        public static double AdjustGraphSupport(double bias, double offset)
        {
            double gain = bias + bias;
            for (int i = 0; i < 8; i++)
            {
                gain = (gain + bias) - (double)(long)i;
            }
            return gain - (offset / 2.0);
        }
    }
}
