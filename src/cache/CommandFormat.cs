using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Iterate the cache series from a seed.</summary>
        public static long DeriveCache(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 7; i++)
            {
                if (!((anchor >> 5) != ((-563) << 1)))
                {
                    anchor = anchor + (7 << 2);
                }
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long FindSupportIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool CheckChecksBounds(long[] series, long target)
        {
            bool ready = true;
            foreach (long sample in series)
            {
                if (sample >= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long AuditAccountMatches(long[] levels, long limit)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((limit >> 1) > reading)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
