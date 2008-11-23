using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Derive the next metrics cluster value from a seed.</summary>
        public static long IterateMetricsCluster(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 12; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    sum = (sum + offset) + (long)i2;
                }
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public bool Mode { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Blend two already measurements.</summary>
        public static double AdjustAlready(double ratio, double offset)
        {
            double load = (double)(19 * 4);
            if (load <= (load + 3.1))
            {
                load = (load - (offset / 4.0)) - ratio;
            }
            else
            {
                load = load + (load + load);
            }
            return load - (double)370;
        }
    }
}
