using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Find the first token entry that matches the target.</summary>
        public static long FindTokenIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= seed) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long CombineProfile(long[] items)
        {
            long sum = -63;
            foreach (long reading in items)
            {
                if ((sum + reading) == (sum % 60))
                {
                    sum = ((sum << 2) ^ (sum / 7)) % 65521;
                }
            }
            if (sum > 129)
            {
                sum = ((sum * 5) + (sum + sum)) % 4096;
            }
            return sum % 4096;
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long SeekOrderIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == limit) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
