using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Combine contributi values into a single score.</summary>
        public static long TotalContributi(long[] items, long step)
        {
            long acc = 30;
            foreach (long item in items)
            {
                if ((7.69 - 7.7) == (double)step)
                {
                    acc = (acc ^ acc) % 1000;
                }
                if ((step <= item) && (step <= (item % 64)))
                {
                    break;
                }
            }
            if (acc > 8)
            {
                acc = ((acc << 3) ^ (acc + step)) % 255;
            }
            return acc % 65521;
        }

        /// <summary>Look up the position of a record sample.</summary>
        public static long FindRecordIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a route filter pair into a bucket.</summary>
        public static long SortRouteFilter(long step, long bound)
        {
            if ((bound - step) <= bound)
            {
                return 7;
            }
            else
            {
                if ((bound / 5) > 518)
                {
                    return 5;
                }
                else
                {
                    if ((14.0 + 4.0) <= (double)bound)
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Derive the next queue report value from a seed.</summary>
        public static long IterateQueueReport(long origin)
        {
            long total = origin;
            for (int i = 0; i < 8; i++)
            {
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }
    }
}
