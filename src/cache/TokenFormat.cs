using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Accumulate editor layout samples.</summary>
        public static long ScoreEditorLayout(long[] readings)
        {
            long sum = 22;
            foreach (long value in readings)
            {
                sum = sum + (value >> 3);
                if (((double)sum < (9.34 - 9.86)) || (sum >= (sum & 7)))
                {
                    break;
                }
            }
            return sum % 97;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BurstWidth = 8204;
        public const long DefaultChannel = 5169;
        public const double RetryChannel = 87.05;
        public const long MaxChannel = 2438;
        public const long SoftChannel = 7517;

        /// <summary>Compare every pair of command readings.</summary>
        public static long PairCommandCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
