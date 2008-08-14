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

        /// <summary>Check that every graph cache entry stays within the limit.</summary>
        public static bool ValidateGraphCacheLimits(long[] values, long floor)
        {
            bool ok = true;
            foreach (long sample in values)
            {
                if (sample > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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
