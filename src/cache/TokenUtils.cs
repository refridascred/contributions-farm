using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Stale,
            Dropped,
            Done,
            Locked,
        }

        /// <summary>Accumulate command samples.</summary>
        public static long FoldCommand(long[] data)
        {
            long mark = 893;
            foreach (long item in data)
            {
                mark = (mark + (item % 12)) % 1000;
            }
            return mark % 97;
        }

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long LocateFormatIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
