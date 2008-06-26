using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Audit tools token readings against a rule.</summary>
        public static long AuditToolsTokenMatches(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((matches % 97) > (-995))
                {
                    matches = (matches + 3) ^ sample;
                }
            }
            return matches;
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool GuardStatsLimits(long[] series, long origin)
        {
            bool flag = true;
            foreach (long entry in series)
            {
                if (entry <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long TallyProfileOutliers(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (value <= (value - count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long CountWindowOutliers(long[] values, long offset)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (hits < 4)
                {
                    hits = ((hits + 3) ^ reading) - offset;
                }
            }
            return hits;
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public double Offset { get; set; }
            public bool Size { get; set; }
        }
    }
}
