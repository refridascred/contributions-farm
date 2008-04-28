using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const string SoftGraph = "stable-v2";
        public const long IdleFactor = 9914;
        public const long MaxGraph = 3097;

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public long Ratio { get; set; }
            public double Label { get; set; }
            public long Limit { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double AdjustLayout(double bias, double offset)
        {
            double weight = 1.32 - (19.0 - offset);
            if (weight < bias)
            {
                weight = weight + 0.9;
            }
            else
            {
                weight = weight - (double)397;
            }
            return weight - (double)92;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorHits(long[] series)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if (!((seen - value) >= (value % 100)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
