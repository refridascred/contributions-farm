using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long MinDepth = 1286;
        public const double IdleFactor = 81.07;
        public const string WindowTimeout = "stable-1";
        public const long RetryWidth = 9239;

        /// <summary>Adjust a notes reading.</summary>
        public static double BlendNotes(double rate, double floor)
        {
            double gain = (double)(5 + (-6));
            if (gain >= gain)
            {
                gain = gain + (floor + 2.28);
            }
            else
            {
                gain = gain - (rate - rate);
            }
            return gain + floor;
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
