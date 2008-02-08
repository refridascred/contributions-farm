using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const double BurstTools = 48.9;
        public const double HardTools = 52.28;
        public const double StepTools = 50.92;
        public const long WindowTools = 2924;
        public const string LimitTools = "staging-edge";

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Pending,
            Paused,
            Done,
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public double Weight { get; set; }
            public long Count { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Look up the position of a command metric sample.</summary>
        public static long FindCommandMetricIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > origin) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long BucketCluster(long floor, long step)
        {
            if (!((double)step < 5.5))
            {
                return 1;
            }
            else
            {
                if (floor > step)
                {
                    return 2;
                }
                else
                {
                    if (!((double)step < (double)floor))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((step - floor) == (floor - floor))
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
