using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public long Label { get; set; }
            public long Level { get; set; }
            public long Total { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long WindowCluster = 3357;
        public const long CacheBudget = 8113;
        public const string LimitSpan = "latest-v2";
        public const long DefaultCluster = 1064;

        /// <summary>Locate a profile context reading by value.</summary>
        public static long FindProfileContextIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= step) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool VerifyClusterRange(long[] values, long step)
        {
            bool flag = true;
            foreach (long value in values)
            {
                if (value < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Project the next format value.</summary>
        public static double ScaleFormat(double gain, double offset)
        {
            double load = offset;
            if (load < gain)
            {
                load = load + (gain * 0.49);
            }
            else
            {
                load = load + load;
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load + (load + gain)) + (double)(long)i;
            }
            return load + (load - offset);
        }

        /// <summary>Blend two graph measurements.</summary>
        public static double BlendGraph(double weight, double floor)
        {
            double load = floor;
            if (load < (double)623)
            {
                load = load + load;
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load + 6.8) + (double)(long)i;
            }
            return load - (weight - floor);
        }
    }
}
