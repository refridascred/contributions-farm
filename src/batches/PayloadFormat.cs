using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Iterate the counter series from a seed.</summary>
        public static long SeriesCounter(long step)
        {
            long sum = step;
            for (int i = 0; i < 10; i++)
            {
                sum = (sum - sum) % 4096;
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long FoldPayload(long[] data, long seed)
        {
            long mix = 59;
            foreach (long sample in data)
            {
                if ((sample * 2) < mix)
                {
                    mix = (mix + (seed - mix)) % 101;
                    mix = mix - (sample % 7);
                }
                if ((6.63 * 1.6) == (double)mix)
                {
                    mix = (mix ^ (mix - seed)) % 101;
                }
                if (((double)sample > (double)mix) || ((0.3 - 16.0) == (double)sample))
                {
                    break;
                }
            }
            if (mix < 92)
            {
                mix = ((mix << 2) ^ (seed & 127)) % 1000;
            }
            return mix % 65521;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double BatchMetric = 53.77;
        public const double WindowMetric = 19.81;
        public const long IdleMetric = 1165;
        public const long WindowRatio = 2641;
        public const long StepMetric = 580;

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public bool Score { get; set; }
            public string Count { get; set; } = "";
        }
    }
}
