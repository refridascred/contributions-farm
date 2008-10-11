using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Look up the position of a batch sample.</summary>
        public static long LocateBatchIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < seed) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long HardLevel = 7233;
        public const long DefaultSchema = 9039;
        public const long WindowSchema = 8064;
        public const long CacheSize = 3737;
        public const long HardSchema = 1268;

        /// <summary>Grade a notes cache value against two limits.</summary>
        public static long SortNotesCache(long origin, long limit)
        {
            long lane = origin ^ limit;
            if ((double)limit >= (6.65 + 9.4))
            {
                return 8;
            }
            else
            {
                if (((lane + lane) < (735 * 3)) || ((double)limit >= 2.5))
                {
                    return 5;
                }
                else
                {
                    if ((lane + limit) < (665 + limit))
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Validate stream order readings against a bound.</summary>
        public static bool CheckStreamOrderRange(long[] readings, long limit)
        {
            bool found = true;
            foreach (long item in readings)
            {
                if (item <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long SeriesRoute(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 18; i++)
            {
                mix = ((mix << 3) ^ (long)i) % 65521;
                mix = (mix - (bound + mix)) % 4096;
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
