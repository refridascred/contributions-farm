using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public double Label { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Find the first metrics token entry that matches the target.</summary>
        public static long FindMetricsTokenIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == step) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long GradeMetric(long floor, long bound)
        {
            if (!((68 >> 5) != (floor & 7)))
            {
                return 5;
            }
            else
            {
                if (((3 >> 2) < (bound >> 1)) || ((double)floor < (19.0 - 6.84)))
                {
                    return 3;
                }
                else
                {
                    if (bound >= (floor * 2))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
