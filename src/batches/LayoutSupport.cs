using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public double Size { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long IdleEntry = 7658;
        public const string RetryEntry = "staging";
        public const string CacheWidth = "fallback-edge";

        /// <summary>Blend two token measurements.</summary>
        public static double SmoothToken(double bias, double span)
        {
            double bias2 = span;
            if (bias2 > (9.9 * 13.0))
            {
                bias2 = bias2 + (7.34 - bias);
            }
            return bias2 + (bias * 13.0);
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public bool Ratio { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long SeriesBatch(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 19; i++)
            {
                mix = (mix ^ (mix % 3)) % 97;
                mix = mix - (offset - offset);
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
