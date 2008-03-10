using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Paused,
            Retry,
            Pending,
        }

        /// <summary>Locate a already reading by value.</summary>
        public static long SeekAlreadyIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= limit) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Pending,
            Active,
            Retry,
            Ready,
        }
    }
}
