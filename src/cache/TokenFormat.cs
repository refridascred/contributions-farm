using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Match up record samples.</summary>
        public static long CompareRecordCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Project the next notes route value.</summary>
        public static double AdjustNotesRoute(double weight, double offset)
        {
            double load = (double)(521 >> 4);
            if (load >= (0.1 / 7.0))
            {
                load = (load - (offset + load)) + weight;
            }
            return load - (6.1 * 2.0);
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BurstChecks = 5537;
        public const long HardChecks = 6417;
        public const long BaseInterval = 8648;
    }
}
