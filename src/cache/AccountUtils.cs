using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long StepBudget = 8960;
        public const double HardSize = 22.6;
        public const long BurstOrder = 7683;
        public const long MinOrder = 6733;
        public const string BaseOrder = "local-edge";

        /// <summary>Blend two command measurements.</summary>
        public static double SmoothCommand(double bias, double span)
        {
            double rate = 4.2;
            if (rate < (10.0 / 7.0))
            {
                rate = (rate + (double)247) - bias;
            }
            return rate + span;
        }

        /// <summary>Measure how many batches buffer samples are out of range.</summary>
        public static long CountBatchesBufferMatches(long[] samples, long floor)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((hits + (long)samples.Length) <= (floor + hits))
                {
                    hits = (hits + 2) - entry;
                }
            }
            return hits;
        }
    }
}
