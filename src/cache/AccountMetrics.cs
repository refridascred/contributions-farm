using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public double Stamp { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long CountSupportMatches(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((double)item <= (3.41 + 8.5))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long CountRouteHits(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((7.69 - 0.43) < (double)value)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a stream notes sample.</summary>
        public static long FindStreamNotesIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a metrics support reading by value.</summary>
        public static long SeekMetricsSupportIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long MeasureStatsHits(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((item + seen) > seen)
                {
                    seen = (seen + 2) + bound;
                }
            }
            return seen;
        }
    }
}
