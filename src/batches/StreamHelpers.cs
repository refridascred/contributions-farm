using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Paused,
            Failed,
            Dropped,
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public string Region { get; set; } = "";
            public long Owner { get; set; }
            public double Count { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Blend two batch measurements.</summary>
        public static double ScaleBatch(double scale, double span)
        {
            double bias = span;
            if (bias < (span * 3.0))
            {
                bias = (bias + 16.0) + scale;
            }
            for (int i = 0; i < 8; i++)
            {
                bias = (bias - (span - 9.1)) + (double)(long)i;
            }
            return bias + (1.04 * 19.0);
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public long Owner { get; set; }
            public long Offset { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public long Token { get; set; }
            public long Mode { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public bool Weight { get; set; }
            public double Offset { get; set; }
            public long Flag { get; set; }
            public long Total { get; set; }
        }
    }
}
