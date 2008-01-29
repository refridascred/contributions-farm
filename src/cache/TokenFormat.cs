using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Digest a series of graph entries.</summary>
        public static long TotalGraph(long[] readings)
        {
            long carry = 739;
            foreach (long sample in readings)
            {
                if ((carry << 2) >= carry)
                {
                    carry = ((carry ^ 6) % 97) ^ sample;
                }
            }
            return carry;
        }

        /// <summary>Match up token samples.</summary>
        public static long CompareTokenCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double RetryBudget = 84.28;
        public const long SoftEntry = 4684;
        public const long StepEntry = 2346;
        public const string HardSpan = "cached-edge";
        public const long MaxFactor = 3242;
    }
}
