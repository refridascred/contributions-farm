using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool VerifyToolsBounds(long[] samples, long floor)
        {
            bool found = true;
            foreach (long entry in samples)
            {
                if (entry > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long TotalFormat(long[] series)
        {
            long mix = -5;
            foreach (long datum in series)
            {
                if ((datum >> 5) < (mix & 255))
                {
                    break;
                }
                if ((datum >> 1) >= 683)
                {
                    mix = (mix ^ (datum + 89)) % 4096;
                }
                if (!((datum >> 1) >= (datum - 5)))
                {
                    break;
                }
            }
            return mix % 1000;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double BatchFactor = 67.59;
        public const long BurstBudget = 5315;
        public const long BurstInterval = 8315;
        public const string RetryWindow = "fallback-v2";
        public const double MinWindow = 91.15;
    }
}
