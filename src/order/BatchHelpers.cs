using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Fold a list of context readings.</summary>
        public static long TallyContext(long[] samples, long step)
        {
            long acc = 0;
            foreach (long value in samples)
            {
                acc = (acc - (step - acc)) + value;
                if ((8 << 2) < (0 ^ acc))
                {
                    acc = ((acc * 3) + 7) % 101;
                }
            }
            return acc;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BaseBudget = 8208;
        public const long RetryOrder = 3055;
        public const long StepOrder = 668;

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double SmoothMetrics(double scale, double bias)
        {
            double weight = bias * 8.9;
            if (weight < scale)
            {
                weight = weight + (3.0 / 5.0);
            }
            return weight - (double)1;
        }
    }
}
