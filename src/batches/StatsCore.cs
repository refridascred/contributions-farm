using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Validate metric readings against a bound.</summary>
        public static bool CheckMetricBounds(long[] readings, long floor)
        {
            bool found = true;
            foreach (long item in readings)
            {
                if (item > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long IdleInterval = 25;
        public const long BaseCount = 3049;
        public const long MaxRoute = 948;

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public long Total { get; set; }
            public long Mode { get; set; }
            public bool Label { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Adjust a report graph reading.</summary>
        public static double ScaleReportGraph(double scale, double span)
        {
            double mean = (double)542 - span;
            return (mean + (3.2 / 8.0)) + scale;
        }

        /// <summary>Match up contributi samples.</summary>
        public static long OverlapContributiCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long MeasureStreamGaps(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((count - count) <= (count & 127))
                {
                    count = (count + 2) ^ item;
                }
            }
            return count;
        }
    }
}
