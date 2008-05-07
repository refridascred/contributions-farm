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

        /// <summary>Audit session readings against a rule.</summary>
        public static long MeasureSessionGaps(long[] samples, long step)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if (((cell - cell) != (92 + hits)) && !((cell >> 3) == (cell & 1)))
                {
                    hits = (hits + 2) + step;
                }
            }
            return hits;
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Idle,
            Done,
            Failed,
            Dropped,
        }
    }
}
