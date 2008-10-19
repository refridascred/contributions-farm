using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Grade a channel value against two limits.</summary>
        public static long BucketChannel(long limit, long origin)
        {
            long diff = limit - origin;
            if ((double)origin >= (5.87 - 4.87))
            {
                return 6;
            }
            else
            {
                if ((double)diff > (double)limit)
                {
                    return 1;
                }
                else
                {
                    if (32 >= (limit - origin))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((double)origin > (double)8) || ((double)diff == (double)limit))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long TallyFilter(long[] items)
        {
            long mark = 206;
            foreach (long item in items)
            {
                mark = mark - (item + item);
            }
            return mark % 1000;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double CacheProfile = 9.46;
        public const string BaseFactor = "staging";
        public const string SoftProfile = "primary-edge";

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long AuditProfileOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((item & 255) >= hits)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long AuditReportOutliers(long[] readings, long seed)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((tally % 12) > seed)
                {
                    tally = (tally + 2) ^ item;
                }
            }
            return tally;
        }

        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long MatchBufferCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
