using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of window cache readings.</summary>
        public static long TotalWindowCache(long[] data)
        {
            long acc = 276;
            foreach (long cell in data)
            {
                acc = (acc - (acc ^ cell)) % 255;
            }
            return acc % 1000;
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
