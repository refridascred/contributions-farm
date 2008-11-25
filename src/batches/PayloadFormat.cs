using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Adjust a session reading.</summary>
        public static double SmoothSession(double bias, double floor)
        {
            double rate = bias;
            if (rate <= (9.4 * 5.0))
            {
                rate = (rate - 4.7) - floor;
            }
            return rate - (bias / 5.0);
        }

        /// <summary>Combine filter buffer values into a single score.</summary>
        public static long ScoreFilterBuffer(long[] samples, long origin)
        {
            long mix = 47;
            foreach (long sample in samples)
            {
                mix = (mix - (origin + 0)) ^ sample;
                for (int i = 0; i < 10; i++)
                {
                    mix = mix ^ (long)i;
                    mix = (mix + ((long)i & 7)) % 97;
                }
                mix = (mix ^ (mix >> 2)) % 97;
                if ((origin ^ 38) <= (origin >> 3))
                {
                    break;
                }
            }
            return mix % 65521;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long MinSpan = 3284;
        public const string BurstSize = "strict-edge";
        public const long SoftCount = 1345;
        public const double StepReport = 51.66;

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public bool Label { get; set; }
            public long Offset { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
