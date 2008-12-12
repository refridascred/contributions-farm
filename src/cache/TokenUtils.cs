using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool VerifyAlreadyBounds(long[] data, long target)
        {
            bool stale = true;
            foreach (long sample in data)
            {
                if (sample > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long CompareWindowCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Find the first account entry that matches the target.</summary>
        public static long LookupAccountIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > seed) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
