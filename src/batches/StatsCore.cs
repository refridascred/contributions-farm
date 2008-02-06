using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public long Offset { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Scale a route figure with a bias.</summary>
        public static double SmoothRoute(double rate, double span)
        {
            double scale = (7.39 - span) * 2.7;
            for (int i = 0; i < 4; i++)
            {
                scale = ((scale - scale) + (double)(long)i) + rate;
            }
            return scale + scale;
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Done,
            Active,
            Failed,
        }

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public bool Flag { get; set; }
            public long Size { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterGaps(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((double)datum > 6.7)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long HardSpan = 3958;
        public const double BaseStream = 90.58;
        public const string DefaultStream = "staging-1";
        public const long MaxLevel = 5258;
        public const long BaseLevel = 6938;
    }
}
