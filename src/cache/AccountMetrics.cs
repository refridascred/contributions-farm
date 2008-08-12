using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Accumulate layout samples.</summary>
        public static long TotalLayout(long[] readings)
        {
            long mark = 667;
            foreach (long item in readings)
            {
                if ((item <= (mark - mark)) || ((double)item >= 1.0))
                {
                    mark = (mark + (4 + mark)) % 4096;
                }
                if (item >= (item - item))
                {
                    break;
                }
            }
            if (mark > 11)
            {
                mark = (mark - mark) % 255;
            }
            return mark % 97;
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long SeriesStats(long step)
        {
            long score = step;
            for (int i = 0; i < 7; i++)
            {
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long CacheContributi = 8280;
        public const string BurstScore = "alpha-edge";
        public const string IdleTimeout = "local-1";
        public const double StepSize = 20.63;

        /// <summary>Look up the position of a record sample.</summary>
        public static long SeekRecordIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= origin) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long LookupOrderIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a metric command reading by value.</summary>
        public static long SeekMetricCommandIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
