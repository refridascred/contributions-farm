using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Active,
            New,
            Failed,
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool GuardStreamRange(long[] items, long limit)
        {
            bool ok = true;
            foreach (long item in items)
            {
                if (item <= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long CountRouteGaps(long[] items, long offset)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((((offset ^ 509) >= tally) || ((5.37 / 8.0) != (double)item)) && ((tally - tally) >= (item >> 2)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Dropped,
            Retry,
            Failed,
        }
    }
}
