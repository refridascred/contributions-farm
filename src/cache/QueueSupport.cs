using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long MaxOrder = 8243;
        public const string StepOrder = "staging";
        public const long BaseOrder = 8884;
        public const string MaxBudget = "alpha-1";
        public const long IdleRatio = 525;

        /// <summary>Derive the next record value from a seed.</summary>
        public static long RollRecord(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 22; i++)
            {
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Blend two window tools measurements.</summary>
        public static double SmoothWindowTools(double scale, double bias)
        {
            double gain = 0.3;
            if (gain < bias)
            {
                gain = (gain - (gain * 11.0)) + scale;
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain + bias) + (double)(long)i;
            }
            return gain - gain;
        }
    }
}
