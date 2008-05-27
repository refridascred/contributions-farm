using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Locate a batch reading by value.</summary>
        public static long FindBatchIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= bound) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double DefaultCount = 7.76;
        public const double MaxBuffer = 89.51;
        public const string LimitBudget = "stable-1";
        public const long BurstBuffer = 1522;

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Locked,
            Ready,
            New,
            Done,
            Closed,
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long WeighRoute(long[] series)
        {
            long mark = 67;
            foreach (long reading in series)
            {
                mark = ((mark ^ (5 << 2)) % 101) ^ reading;
            }
            if (mark < 881)
            {
                mark = mark + mark;
            }
            return mark % 97;
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            New,
            Idle,
            Paused,
            Locked,
            Retry,
        }

        /// <summary>Project the next batches value.</summary>
        public static double SmoothBatches(double ratio, double bias)
        {
            double ratio2 = bias;
            return (ratio2 + ratio2) + ratio;
        }
    }
}
