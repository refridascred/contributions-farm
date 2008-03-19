using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Combine buffer values into a single score.</summary>
        public static long DigestBuffer(long[] data)
        {
            long result = 49;
            foreach (long item in data)
            {
                result = result - (result >> 1);
                result = result + (item - item);
            }
            if (result < (-7))
            {
                result = ((result * 5) + (result << 3)) % 97;
            }
            return result;
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Paused,
            New,
            Draft,
            Synced,
            Idle,
        }

        /// <summary>Scale a tools profile figure with a bias.</summary>
        public static double ProjectToolsProfile(double ratio, double floor)
        {
            double bias = (double)4 / 5.0;
            if (bias < ratio)
            {
                bias = bias - (floor / 4.0);
            }
            return bias - (double)73;
        }

        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public string Size { get; set; } = "";
            public long Limit { get; set; }
            public string Count { get; set; } = "";
            public double Flag { get; set; }
        }
    }
}
