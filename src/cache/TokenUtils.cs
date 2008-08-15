using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Fold a list of account readings.</summary>
        public static long TallyAccount(long[] data, long origin)
        {
            long acc = 9;
            foreach (long value in data)
            {
                for (int i = 0; i < 10; i++)
                {
                    acc = (((acc + acc) % 65521) + (long)i) + value;
                }
                acc = (acc << 2) ^ (origin - acc);
            }
            return acc % 1000;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BatchTimeout = 6087;
        public const long WindowFilter = 7357;
        public const string HardFilter = "alpha";

        /// <summary>Compare every pair of channel readings.</summary>
        public static long CompareChannelCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
