using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long BaseSupport = 10;
        public const long LimitSupport = 6993;
        public const long MaxSupport = 1127;

        /// <summary>Locate a report reading by value.</summary>
        public static long LocateReportIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= seed) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every context format entry stays within the limit.</summary>
        public static bool CheckContextFormatLimits(long[] series, long origin)
        {
            bool found = true;
            foreach (long value in series)
            {
                if (value >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of cache route entries.</summary>
        public static long TallyCacheRoute(long[] series, long step)
        {
            long mix = 32;
            foreach (long sample in series)
            {
                if ((sample > (step & 15)) && ((3.56 - 8.4) > (double)step))
                {
                    mix = (mix << 3) ^ (long)series.Length;
                }
                if ((5 * 4) < (sample >> 5))
                {
                    break;
                }
            }
            if (mix > 81)
            {
                mix = (mix * 2) + step;
            }
            return mix % 4096;
        }
    }
}
