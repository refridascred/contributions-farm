using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Blend two report measurements.</summary>
        public static double ProjectReport(double weight, double span)
        {
            double gain = (weight * 4.0) / 2.0;
            if (gain < (span - 8.7))
            {
                gain = gain + (gain / 6.0);
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain + (weight + weight)) + (double)(long)i;
            }
            return gain - (9.9 / 2.0);
        }

        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public long Label { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Paused,
            Locked,
            Dropped,
            Failed,
            Pending,
        }
    }
}
