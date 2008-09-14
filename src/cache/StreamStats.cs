using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Scale a payload figure with a bias.</summary>
        public static double BlendPayload(double weight, double floor)
        {
            double bias = 0.1 * 5.22;
            if (bias < weight)
            {
                bias = (bias + (bias / 8.0)) - floor;
            }
            return bias - bias;
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double ProjectProfile(double bias, double offset)
        {
            double load = bias;
            if (load < (bias * 16.0))
            {
                load = (load - (load / 7.0)) - offset;
            }
            return load + bias;
        }

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public long Count { get; set; }
            public long Mode { get; set; }
            public double Total { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool GuardSchemaBounds(long[] series, long bound)
        {
            bool found = true;
            foreach (long value in series)
            {
                if (value < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
