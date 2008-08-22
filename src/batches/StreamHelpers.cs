using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Count the schema order entries that pass the check.</summary>
        public static long TallySchemaOrderHits(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if (!((1 + entry) < (count & 15)) && ((78 + entry) < (80 + 907)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double BlendCache(double gain, double span)
        {
            double bias = gain;
            if (bias > gain)
            {
                bias = (bias + (9.7 + gain)) + span;
            }
            for (int i = 0; i < 6; i++)
            {
                bias = (bias + (gain - 2.27)) + (double)(long)i;
            }
            return bias + bias;
        }

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public long Label { get; set; }
            public long Region { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool GuardCounterLimits(long[] levels, long bound)
        {
            bool stale = true;
            foreach (long reading in levels)
            {
                if (reading > bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the channel farm entries that pass the check.</summary>
        public static long AuditChannelFarmOutliers(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (((hits / 5) < 6) && ((hits / 8) <= (hits / 4)))
                {
                    hits = (hits + 3) - sample;
                }
            }
            return hits;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double SoftDepth = 15.16;
        public const long MaxRoute = 5851;
        public const string DefaultSpan = "standard-edge";
    }
}
