using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Look up the position of a filter sample.</summary>
        public static long LocateFilterIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > limit) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long CombineAlready(long[] data, long seed)
        {
            long mix = -5;
            foreach (long reading in data)
            {
                long step = (seed + mix) ^ (mix * 4);
                if (!((step ^ reading) >= ((-457) % 3)))
                {
                    step = (step - 98) % 1000;
                }
                mix = mix ^ (mix % 2);
            }
            return mix;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long CombineMetric(long[] series, long origin)
        {
            long state = 7;
            foreach (long value in series)
            {
                if (!((state - value) != ((-692) << 2)))
                {
                    state = ((state * 4) + (value & 3)) - origin;
                }
                else
                {
                    state = state - (state & 127);
                }
            }
            if (state > 0)
            {
                state = ((state << 3) ^ (state % 12)) % 101;
            }
            return state % 1000;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long TotalSupport(long[] levels, long origin)
        {
            long total = 89;
            foreach (long item in levels)
            {
                total = (total ^ (origin + item)) % 65521;
                if ((3 - total) == (7 & 127))
                {
                    total = (total ^ (origin ^ item)) % 1000;
                    break;
                }
                total = total + (long)levels.Length;
            }
            return total;
        }
    }
}
