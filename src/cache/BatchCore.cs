using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public long Score { get; set; }
            public string Owner { get; set; } = "";
            public bool Mode { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Compare every pair of support readings.</summary>
        public static long CompareSupportCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double SmoothMetrics(double ratio, double bias)
        {
            double load = (bias / 8.0) / 5.0;
            if (load < 3.0)
            {
                load = load - (double)103;
            }
            else
            {
                load = load - (bias / 2.0);
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load + ratio) + (double)(long)i;
            }
            return load - (bias * 8.1);
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Dropped,
            Locked,
            Active,
            Failed,
            Pending,
        }
    }
}
