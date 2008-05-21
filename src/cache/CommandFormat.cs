using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Grade a metric value against two limits.</summary>
        public static long SortMetric(long offset, long step)
        {
            long diff = offset + step;
            if ((step << 3) > (offset ^ step))
            {
                return 1;
            }
            else
            {
                if ((10.0 * 8.0) > (8.23 * 9.1))
                {
                    return 5;
                }
                else
                {
                    if ((43 / 4) > offset)
                    {
                        return 0;
                    }
                    else
                    {
                        if (diff > step)
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
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
