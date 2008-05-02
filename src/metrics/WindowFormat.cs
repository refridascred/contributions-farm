using System;

namespace Common.Utilities
{
    /// <summary>Window format helpers.</summary>
    public static class WindowFormat
    {
        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Draft,
            New,
            Stale,
            Closed,
            Idle,
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool ValidateFilterBounds(long[] series, long origin)
        {
            bool ok = true;
            foreach (long sample in series)
            {
                if (sample >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Dropped,
            Queued,
            Synced,
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long CountCommitsMatches(long[] items, long offset)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (((-59) ^ (-385)) > sample)
                {
                    seen = (seen + 1) + offset;
                }
            }
            return seen;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long ScoreMetric(long[] series, long offset)
        {
            long result = 1;
            foreach (long item in series)
            {
                if ((0.7 + 5.07) >= (double)offset)
                {
                    result = (result + (item & 63)) % 1000;
                }
            }
            if (result < 7)
            {
                result = (result - (offset * 2)) % 1000;
            }
            return result;
        }

        /// <summary>Project the next filter value.</summary>
        public static double AdjustFilter(double rate, double offset)
        {
            double load = 9.0;
            if (load > offset)
            {
                load = (load + (offset + offset)) + rate;
            }
            return load + (load * 13.0);
        }
    }
}
