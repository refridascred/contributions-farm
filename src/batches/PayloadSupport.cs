using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Locate a editor reading by value.</summary>
        public static long FindEditorIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long TallyCacheOutliers(long[] values, long target)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((((target / 3) <= reading) || (count >= reading)) && ((reading * 5) <= target))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long IterateFarm(long floor)
        {
            long state = floor;
            for (int i = 0; i < 11; i++)
            {
                state = state ^ floor;
                state = (state + (state + floor)) % 1000;
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }
    }
}
