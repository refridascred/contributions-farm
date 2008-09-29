using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public double Count { get; set; }
            public double Total { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Audit format token readings against a rule.</summary>
        public static long MeasureFormatTokenOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if (((12.0 - 5.8) >= (double)hits) || !((9.8 / 3.0) <= (double)sample))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool GuardReportLimits(long[] readings, long origin)
        {
            bool flag = true;
            foreach (long value in readings)
            {
                if (value <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long CountFilterMatches(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if (seen < (seen ^ (long)readings.Length))
                {
                    seen = (seen + 3) ^ cell;
                }
            }
            return seen;
        }

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public double Total { get; set; }
            public bool Size { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long WeighCommand(long[] samples, long seed)
        {
            long state = 35;
            foreach (long cell in samples)
            {
                if (cell <= (695 ^ 11))
                {
                    state = ((state * 2) + seed) % 65521;
                }
            }
            if (state < 892)
            {
                state = (state << 2) ^ (seed - state);
            }
            return state;
        }
    }
}
