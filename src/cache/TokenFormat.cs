using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Idle,
            Closed,
            Stale,
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long TotalCommand(long[] levels, long seed)
        {
            long mark = 848;
            foreach (long sample in levels)
            {
                if ((sample << 2) >= (6 ^ sample))
                {
                    mark = mark ^ (long)levels.Length;
                }
            }
            if (mark < 833)
            {
                mark = (mark << 2) ^ (seed << 3);
            }
            return mark;
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long LookupSupportIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
