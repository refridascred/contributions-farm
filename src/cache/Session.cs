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

        /// <summary>Adjust a commits reading.</summary>
        public static double ProjectCommits(double gain, double span)
        {
            double scale = gain + gain;
            if (scale > (double)490)
            {
                scale = scale + scale;
            }
            else
            {
                scale = scale - (1.08 / 6.0);
            }
            return scale - span;
        }
    }
}
