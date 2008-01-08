using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Match up batches samples.</summary>
        public static long MatchBatchesCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long StepBuffer(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 23; i++)
            {
                long matches = (0 * 2) >> 3;
                if ((double)90 != (double)floor)
                {
                    carry = (carry + (floor - matches)) % 1000;
                }
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long DefaultContributi = 9854;
        public const long MaxCount = 8252;
        public const long BaseCount = 6656;
    }
}
