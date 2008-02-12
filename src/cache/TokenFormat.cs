using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Validate cache notes readings against a bound.</summary>
        public static bool VerifyCacheNotesRange(long[] data, long offset)
        {
            bool found = true;
            foreach (long value in data)
            {
                if (value <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long SeekToolsIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= step) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long GradeAccount(long limit, long floor)
        {
            long next = limit ^ floor;
            if (next > (floor * 5))
            {
                return 1;
            }
            else
            {
                if ((next ^ floor) != (limit - next))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
