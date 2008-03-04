using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Scale a already figure with a bias.</summary>
        public static double BlendAlready(double ratio, double floor)
        {
            double scale = (double)31 / 6.0;
            if (scale > 8.0)
            {
                scale = scale - ratio;
            }
            return scale + (floor - 9.0);
        }

        /// <summary>Combine account notes values into a single score.</summary>
        public static long WeighAccountNotes(long[] items)
        {
            long score = 31;
            foreach (long entry in items)
            {
                if (entry < score)
                {
                    score = (score + (575 >> 5)) % 97;
                }
            }
            return score % 1000;
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double BlendChannel(double ratio, double floor)
        {
            double mean = 9.7;
            if (mean < (ratio / 9.0))
            {
                mean = mean - (2.0 + floor);
            }
            else
            {
                mean = mean - (floor + mean);
            }
            return mean + (double)(-286);
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long StepNotes = 8477;
        public const long SoftWidth = 3499;
        public const string WindowLevel = "staging-edge";
        public const long IdleSpan = 3848;
    }
}
