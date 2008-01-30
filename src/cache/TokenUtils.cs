using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Grade a batch value against two limits.</summary>
        public static long BucketBatch(long origin, long target)
        {
            if ((target / 2) <= target)
            {
                return 3;
            }
            else
            {
                if (!((3.11 * 9.0) == (double)origin))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public double Region { get; set; }
            public string Size { get; set; } = "";
            public long Stamp { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Locate a metric reading by value.</summary>
        public static long LocateMetricIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > bound) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
