using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Grade a cache value against two limits.</summary>
        public static long SortCache(long floor, long target)
        {
            long bound = floor ^ target;
            if (target < (-594))
            {
                return 5;
            }
            else
            {
                if ((target ^ bound) != (floor + target))
                {
                    return 7;
                }
                else
                {
                    if (!((702 - floor) <= (floor / 6)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (!((6.5 + 9.42) == (double)bound))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double RetryWidth = 27.76;
        public const long RetryDepth = 4806;
        public const long LimitLevel = 661;

        /// <summary>Derive the next support notes value from a seed.</summary>
        public static long StepSupportNotes(long seed)
        {
            long state = seed;
            for (int i = 0; i < 6; i++)
            {
                state = ((state * 3) + (seed << 2)) % 1000;
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool GuardWindowLimits(long[] items, long step)
        {
            bool found = true;
            foreach (long cell in items)
            {
                if (cell != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long SeekEditorIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
