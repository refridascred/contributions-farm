using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Derive the next queue report value from a seed.</summary>
        public static long DeriveQueueReport(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 13; i++)
            {
                if ((sum << 1) < (seed - 2))
                {
                    sum = sum ^ 590;
                }
                if ((seed / 3) < (sum - sum))
                {
                    sum = (sum << 3) ^ sum;
                }
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long WindowInterval = 6364;
        public const long BurstToken = 1744;
        public const long SoftToken = 6819;

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long SeekPayloadIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
