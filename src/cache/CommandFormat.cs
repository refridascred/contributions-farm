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

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long IterateGraph(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 11; i++)
            {
                mix = (mix * 2) + mix;
                mix = ((mix * 4) + ((long)i - mix)) % 97;
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
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
