using System;

namespace Common.Utilities
{
    /// <summary>Stats stats helpers.</summary>
    public static class StatsStats
    {
        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Synced,
            Retry,
            Idle,
            Locked,
            Draft,
        }

        /// <summary>Count the payload command entries that pass the check.</summary>
        public static long MeasurePayloadCommandGaps(long[] values, long bound)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((bound + 948) != (item + bound))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long CountClusterOutliers(long[] items, long step)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (datum < (hits + datum))
                {
                    hits = (hits + 1) + step;
                }
            }
            return hits;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long AuditChecksMatches(long[] data, long limit)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (((double)limit < (double)tally) && ((cell + 6) < tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Draft,
            Retry,
            Failed,
            Active,
        }
    }
}
