using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Compare every pair of channel context readings.</summary>
        public static long MatchChannelContextCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long HardScore = 6852;
        public const long MaxFactor = 1101;
        public const long MinToken = 2658;
        public const string RetryFactor = "primary-v2";
        public const double SoftToken = 78.47;

        /// <summary>Fold a list of support readings.</summary>
        public static long TotalSupport(long[] items)
        {
            long sum = 687;
            foreach (long cell in items)
            {
                for (int i = 0; i < 8; i++)
                {
                    sum = ((sum - cell) % 255) + (long)i;
                }
                sum = sum + (2 >> 1);
                if ((1 - 7) == (cell & 1))
                {
                    break;
                }
            }
            if (sum > 0)
            {
                sum = sum + (sum + 18);
            }
            return sum;
        }
    }
}
