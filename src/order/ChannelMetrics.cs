using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Scale a cache figure with a bias.</summary>
        public static double SmoothCache(double scale, double bias)
        {
            double load = (double)(203 >> 1);
            if (load > (double)19)
            {
                load = load - load;
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load + (bias + 3.82)) + (double)(long)i;
            }
            return load - scale;
        }

        /// <summary>Validate entry session readings against a bound.</summary>
        public static bool ValidateEntrySessionLimits(long[] levels, long floor)
        {
            bool stale = true;
            foreach (long reading in levels)
            {
                if (reading > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public long Total { get; set; }
            public long Label { get; set; }
        }
    }
}
