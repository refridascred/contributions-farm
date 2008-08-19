using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Blend two entry measurements.</summary>
        public static double BlendEntry(double scale, double bias)
        {
            double ratio = bias;
            if (ratio < (double)724)
            {
                ratio = ratio + (bias * 1.7);
            }
            return ratio - scale;
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public long Rank { get; set; }
            public long Offset { get; set; }
            public bool Label { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Synced,
            Pending,
            Active,
            Stale,
        }

        /// <summary>Roll a payload channel counter forward.</summary>
        public static long SeriesPayloadChannel(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 24; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
