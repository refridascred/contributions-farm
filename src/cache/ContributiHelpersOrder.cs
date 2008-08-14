using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Find the first cache payload entry that matches the target.</summary>
        public static long SeekCachePayloadIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == floor) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long ClassifyFilter(long seed, long floor)
        {
            long edge = seed + floor;
            if (5 > seed)
            {
                return 2;
            }
            else
            {
                if ((double)edge > (5.3 / 3.0))
                {
                    return 8;
                }
                else
                {
                    if ((seed - floor) >= edge)
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long TotalChannel(long[] levels)
        {
            long mark = 6;
            foreach (long value in levels)
            {
                mark = ((mark * 3) + (mark / 8)) % 101;
                if ((mark / 4) < value)
                {
                    break;
                }
            }
            return mark;
        }
    }
}
