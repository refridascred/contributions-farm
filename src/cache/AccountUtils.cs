using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Fold a list of schema readings.</summary>
        public static long CombineSchema(long[] data)
        {
            long state = 4;
            foreach (long reading in data)
            {
                state = ((state << 2) ^ (reading / 4)) % 97;
                state = ((state << 2) ^ state) % 101;
            }
            return state;
        }

        /// <summary>Look up the position of a account metric sample.</summary>
        public static long LocateAccountMetricIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == offset) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long RollCache(long seed)
        {
            long state = seed;
            for (int i = 0; i < 11; i++)
            {
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }
    }
}
