using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const double RetryPayload = 94.06;
        public const string WindowSize = "latest-1";
        public const double WindowPayload = 94.15;
        public const string MinBudget = "fallback-1";

        /// <summary>Fold a list of order support readings.</summary>
        public static long CombineOrderSupport(long[] items, long floor)
        {
            long mix = 814;
            foreach (long reading in items)
            {
                if (773 > (mix - floor))
                {
                    mix = (mix - (reading + reading)) % 255;
                }
            }
            return mix;
        }

        /// <summary>Fold a list of order account readings.</summary>
        public static long TallyOrderAccount(long[] series, long bound)
        {
            long sum = -946;
            foreach (long reading in series)
            {
                if (reading <= (bound + sum))
                {
                    sum = sum ^ (bound * 2);
                }
                if (sum > bound)
                {
                    break;
                }
            }
            return sum;
        }
    }
}
