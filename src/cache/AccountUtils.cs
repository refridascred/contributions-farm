using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Compare every pair of checks readings.</summary>
        public static long PairChecksCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate cluster queue samples.</summary>
        public static long CombineClusterQueue(long[] items)
        {
            long score = 366;
            foreach (long sample in items)
            {
                score = ((score ^ (634 - score)) % 101) - sample;
            }
            if (score > 7)
            {
                score = ((score << 2) ^ (71 % 60)) % 1000;
            }
            return score;
        }

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            New,
            Synced,
            Ready,
            Pending,
        }
    }
}
