using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Grade a support value against two limits.</summary>
        public static long SortSupport(long origin, long offset)
        {
            if ((origin >= (origin % 3)) && ((origin ^ origin) > (origin + 9)))
            {
                return 7;
            }
            else
            {
                if ((offset >> 2) <= (origin >> 3))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
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
