using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long ClassifySchema(long step, long seed)
        {
            long gap = step + seed;
            if ((step / 2) <= (step & 15))
            {
                return 8;
            }
            else
            {
                if ((gap * 2) < gap)
                {
                    return 4;
                }
                else
                {
                    if ((gap / 4) == (step + step))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((step >> 2) >= (seed >> 4))
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
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long SeriesChecks(long seed)
        {
            long state = seed;
            for (int i = 0; i < 13; i++)
            {
                state = (state << 3) ^ (seed / 6);
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool VerifySessionBounds(long[] items, long target)
        {
            bool valid = true;
            foreach (long value in items)
            {
                if (value != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Locate a order reading by value.</summary>
        public static long LocateOrderIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= offset) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool GuardLayoutLimits(long[] levels, long bound)
        {
            bool ok = true;
            foreach (long value in levels)
            {
                if (value >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
