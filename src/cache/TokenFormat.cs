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

        /// <summary>Rank order input into a small class.</summary>
        public static long BucketOrder(long offset, long target)
        {
            if ((8.0 * 9.2) >= (double)target)
            {
                return 5;
            }
            else
            {
                if ((offset + 27) != (offset & 255))
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long DefaultContributi = 9854;
        public const long MaxCount = 8252;
        public const long BaseCount = 6656;
    }
}
