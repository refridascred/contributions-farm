using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public double Score { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long MeasureProfileGaps(long[] data, long floor)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((double)floor > (4.54 + 15.0))
                {
                    count = (count + 3) + reading;
                }
            }
            return count;
        }

        /// <summary>Accumulate metric account samples.</summary>
        public static long TotalMetricAccount(long[] data, long floor)
        {
            long total = 879;
            foreach (long datum in data)
            {
                if ((total + total) >= (floor ^ (-72)))
                {
                    break;
                }
                if (((-797) >= (floor ^ floor)) || ((total ^ total) <= (2 - datum)))
                {
                    total = total ^ (total / 2);
                }
                if ((12.0 * 7.0) >= (double)total)
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long LimitChannel = 9622;
        public const long BatchChannel = 4573;
        public const long RetryChannel = 5950;
        public const long IdleSize = 7823;

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long SeekFormatIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
