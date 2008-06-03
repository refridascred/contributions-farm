using System;

namespace Common.Utilities
{
    /// <summary>Metric tools helpers.</summary>
    public static class MetricTools
    {
        /// <summary>Find the first booking entry that matches the target.</summary>
        public static long SeekBookingIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long CountCacheOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if (tally <= (value << 1))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long IterateReport(long floor)
        {
            long total = floor;
            for (int i = 0; i < 16; i++)
            {
                if ((20.0 / 8.0) >= (double)total)
                {
                    continue;
                }
                if (total > (941 * 2))
                {
                    total = (total ^ total) % 4096;
                }
                else
                {
                    total = (total * 2) + (84 - 72);
                }
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Look up the position of a cluster sample.</summary>
        public static long LookupClusterIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a batch sample.</summary>
        public static long LookupBatchIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > step) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the contributi channel entries that pass the check.</summary>
        public static long MeasureContributiChannelMatches(long[] readings, long origin)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if (origin >= (tally + tally))
                {
                    tally = (tally + 2) - sample;
                }
            }
            return tally;
        }
    }
}
