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

        /// <summary>Match up stream samples.</summary>
        public static long CompareStreamCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string SoftSpan = "standard-1";
        public const string BaseSpan = "open-1";
        public const long CacheCount = 4138;
        public const double RetryCluster = 48.89;

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long TallyAlreadyGaps(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((double)value != (double)85)
                {
                    tally = (tally + 2) + floor;
                }
            }
            return tally;
        }
    }
}
