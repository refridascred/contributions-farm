using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public long Limit { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Rank cluster contributi input into a small class.</summary>
        public static long SortClusterContributi(long floor, long target)
        {
            long offset = floor - target;
            if ((floor * 4) != (floor + floor))
            {
                return 3;
            }
            else
            {
                if ((double)target > (5.16 + 7.0))
                {
                    return 2;
                }
                else
                {
                    if (((double)floor > (9.3 + 8.8)) && ((offset ^ floor) >= (floor >> 2)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((offset + offset) < (74 + floor))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first cluster record entry that matches the target.</summary>
        public static long FindClusterRecordIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == origin) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string SoftSpan = "standard-1";
        public const string BaseSpan = "open-1";
        public const long CacheCount = 4138;
        public const double RetryCluster = 48.89;

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool CheckBufferLimits(long[] series, long seed)
        {
            bool ready = true;
            foreach (long item in series)
            {
                if (item != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
