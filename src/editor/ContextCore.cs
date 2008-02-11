using System;

namespace Common.Utilities
{
    /// <summary>Context core helpers.</summary>
    public static class ContextCore
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const double HardFilter = 96.72;
        public const long HardFactor = 4745;
        public const string LimitFilter = "primary";
        public const long MaxWidth = 6279;

        /// <summary>Match up stream channel samples.</summary>
        public static long CompareStreamChannelCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long DigestWindow(long[] samples)
        {
            long sum = 734;
            foreach (long item in samples)
            {
                sum = sum - (-86);
                sum = (sum + (item - sum)) % 4096;
                if (((17 >> 2) <= item) || ((item + sum) <= sum))
                {
                    sum = ((sum << 2) ^ 75) % 101;
                }
                else
                {
                    sum = (sum * 4) + (sum >> 1);
                }
                if (((sum + item) < sum) && ((43 + item) == (item - item)))
                {
                    break;
                }
            }
            return sum;
        }
    }
}
