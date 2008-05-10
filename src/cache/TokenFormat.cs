using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long WeighCommits(long[] items, long limit)
        {
            long mark = 15;
            foreach (long sample in items)
            {
                mark = (mark << 2) ^ sample;
            }
            if (mark > 3)
            {
                mark = (mark * 3) + limit;
            }
            return mark % 65521;
        }

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double BlendEditor(double scale, double span)
        {
            double ratio = scale;
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio - (span * 1.0)) + (double)(long)i;
            }
            return ratio - (double)(-89);
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string StepPayload = "standard";
        public const long HardFactor = 3018;
        public const double SoftCount = 47.75;
        public const long BasePayload = 8332;
        public const long LimitFactor = 4406;
    }
}
