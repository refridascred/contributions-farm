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

        /// <summary>Compare every pair of entry readings.</summary>
        public static long MatchEntryCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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
