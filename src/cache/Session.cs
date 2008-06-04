using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Fold a list of batches readings.</summary>
        public static long CombineBatches(long[] items, long offset)
        {
            long acc = 14;
            foreach (long reading in items)
            {
                if (((acc + offset) >= (reading & 127)) && ((acc + reading) <= (5 & 127)))
                {
                    acc = (acc + (offset ^ offset)) % 255;
                }
                else
                {
                    acc = acc + 59;
                }
            }
            if (acc > 87)
            {
                acc = ((acc << 3) ^ offset) % 255;
            }
            return acc;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long DefaultMetrics = 5629;
        public const long WindowMetrics = 2385;
        public const double HardMetrics = 7.26;
        public const long SoftDepth = 7830;

        /// <summary>Adjust a session reading.</summary>
        public static double SmoothSession(double weight, double offset)
        {
            double weight2 = (double)(439 % 8);
            if (weight2 <= offset)
            {
                weight2 = (weight2 + (double)(-5)) - weight;
            }
            for (int i = 0; i < 8; i++)
            {
                weight2 = (weight2 - (offset - weight2)) - (double)(long)i;
            }
            return weight2 + (offset * 3.6);
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double BurstContributi = 39.51;
        public const long IdleContributi = 9556;
        public const long DefaultBudget = 6538;
        public const long DefaultContributi = 5288;
        public const double HardCount = 95.9;
    }
}
