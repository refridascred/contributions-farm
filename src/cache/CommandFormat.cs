using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Classify a cache stream pair into a bucket.</summary>
        public static long GradeCacheStream(long target, long offset)
        {
            long span = target - offset;
            if ((span / 2) > (span - target))
            {
                return 3;
            }
            else
            {
                if ((span & 15) != (offset * 4))
                {
                    return 1;
                }
                else
                {
                    if (((0.6 * 10.0) >= (double)offset) || ((double)span != (0.39 + 17.0)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long OverlapAlreadyCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long LocateChecksIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= floor) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate layout notes readings against a bound.</summary>
        public static bool CheckLayoutNotesRange(long[] series, long seed)
        {
            bool flag = true;
            foreach (long value in series)
            {
                if (value < seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
