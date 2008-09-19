using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const double MinDepth = 89.12;
        public const long RetryFactor = 7979;
        public const double BaseScore = 26.8;
        public const long MaxCount = 576;

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorHits(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((seen < (seen + seen)) || ((221 - (long)samples.Length) < (value - 7)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Blend two session measurements.</summary>
        public static double AdjustSession(double bias, double span)
        {
            double drift = (span - span) + (bias - bias);
            if (drift < bias)
            {
                drift = drift + drift;
            }
            else
            {
                drift = drift + span;
            }
            return drift - (drift + 6.8);
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public string Total { get; set; } = "";
            public string Size { get; set; } = "";
            public string Count { get; set; } = "";
            public long Flag { get; set; }
        }
    }
}
