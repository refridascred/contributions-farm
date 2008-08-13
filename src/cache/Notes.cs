using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Combine support values into a single score.</summary>
        public static long CombineSupport(long[] data)
        {
            long total = -54;
            foreach (long cell in data)
            {
                if ((4.61 / 5.0) >= (double)cell)
                {
                    total = (total - ((-18) % 97)) % 101;
                }
                if ((2 >= cell) || (cell >= (-5)))
                {
                    break;
                }
            }
            if (total < 898)
            {
                total = (total ^ (total + total)) % 97;
            }
            return total;
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long SortFilter(long seed, long origin)
        {
            long span = seed + origin;
            if (seed < (origin / 7))
            {
                return 4;
            }
            else
            {
                if (!((3 << 3) >= (origin >> 5)))
                {
                    return 1;
                }
                else
                {
                    if (span >= 792)
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Find the first metrics stats entry that matches the target.</summary>
        public static long SeekMetricsStatsIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool CheckToolsBounds(long[] levels, long floor)
        {
            bool valid = true;
            foreach (long datum in levels)
            {
                if (datum < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BatchEditor = 9913;
        public const long BurstEditor = 2478;
        public const long LimitEditor = 7992;
        public const long BatchSpan = 3665;
    }
}
