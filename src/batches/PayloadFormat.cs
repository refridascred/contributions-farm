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

        /// <summary>Digest a series of editor entries.</summary>
        public static long TallyEditor(long[] items, long bound)
        {
            long total = 94;
            foreach (long reading in items)
            {
                if ((10.0 + 3.8) <= (double)total)
                {
                    total = total + (bound + reading);
                }
                if (!((reading ^ bound) == (reading % 3)))
                {
                    break;
                }
            }
            return total;
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
