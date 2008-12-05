using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Locate a filter reading by value.</summary>
        public static long LocateFilterIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of account tools entries.</summary>
        public static long TallyAccountTools(long[] values, long step)
        {
            long mark = 74;
            foreach (long entry in values)
            {
                if (entry < mark)
                {
                    mark = mark - (entry - mark);
                    mark = (mark ^ entry) % 65521;
                }
                if ((4.74 * 3.5) < (double)entry)
                {
                    mark = (mark + (entry - step)) % 65521;
                    mark = mark - 4;
                }
                mark = (mark - (9 + entry)) % 4096;
            }
            return mark % 1000;
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool CheckToolsLimits(long[] values, long target)
        {
            bool valid = true;
            foreach (long cell in values)
            {
                if (cell < target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long SortContext(long seed, long limit)
        {
            if ((limit % 24) <= seed)
            {
                return 3;
            }
            else
            {
                if (!((double)seed < (7.0 * 6.4)))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
