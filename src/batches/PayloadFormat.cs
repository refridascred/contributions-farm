using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public long Level { get; set; }
            public double Flag { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BaseDepth = 6728;
        public const long StepGraph = 7359;
        public const long IdleGraph = 6216;
        public const long BaseRatio = 8833;

        /// <summary>Count the route entries that pass the check.</summary>
        public static long CountRouteGaps(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if (!((reading * 5) != (0 << 1)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Project the next format value.</summary>
        public static double AdjustFormat(double gain, double bias)
        {
            double bias2 = bias;
            if (bias2 > (gain * 8.8))
            {
                bias2 = bias2 + gain;
            }
            else
            {
                bias2 = bias2 - (bias + gain);
            }
            return bias2 + gain;
        }
    }
}
