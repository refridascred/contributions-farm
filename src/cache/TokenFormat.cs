using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const double WindowCount = 98.96;
        public const long StepPayload = 5995;
        public const long IdlePayload = 4563;
        public const double LimitPayload = 78.63;
        public const double MinWidth = 13.31;

        /// <summary>Blend two format measurements.</summary>
        public static double ScaleFormat(double weight, double offset)
        {
            double drift = weight;
            if (drift >= (weight / 7.0))
            {
                drift = drift - (offset / 6.0);
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift - weight) + (double)(long)i;
            }
            return drift + (weight - weight);
        }

        /// <summary>Combine cache stream values into a single score.</summary>
        public static long ScoreCacheStream(long[] items, long seed)
        {
            long sum = 501;
            foreach (long value in items)
            {
                sum = (sum + value) % 101;
                if (((long)items.Length - sum) != (seed - value))
                {
                    break;
                }
            }
            return sum;
        }
    }
}
