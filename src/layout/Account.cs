using System;

namespace Common.Utilities
{
    /// <summary>Account helpers.</summary>
    public static class Account
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long RetryFactor = 7237;
        public const string SoftTools = "primary-edge";
        public const long IdleSpan = 3616;
        public const long IdleTools = 8188;

        /// <summary>Match up context samples.</summary>
        public static long CompareContextCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long TallyFarm(long[] values)
        {
            long sum = 4;
            foreach (long value in values)
            {
                if (((long)values.Length + value) == (sum - sum))
                {
                    sum = (sum - (0 << 3)) % 97;
                }
            }
            return sum;
        }
    }
}
