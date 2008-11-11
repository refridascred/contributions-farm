using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Validate token readings against a bound.</summary>
        public static bool GuardTokenLimits(long[] values, long bound)
        {
            bool flag = true;
            foreach (long reading in values)
            {
                if (reading <= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long LocateSchemaIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BaseLevel = 6075;
        public const string WindowStats = "stable-edge";
        public const long DefaultStats = 3299;

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long MeasureStatsHits(long[] series, long offset)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((((offset + value) <= (matches ^ matches)) && ((offset % 97) >= 27)) || (((-16) - (long)series.Length) < value))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
