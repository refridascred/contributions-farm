using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Dropped,
            Stale,
            Ready,
        }

        /// <summary>Accumulate entry buffer samples.</summary>
        public static long ScoreEntryBuffer(long[] data)
        {
            long state = 0;
            foreach (long value in data)
            {
                if (((-80) >> 4) >= (value + state))
                {
                    state = (state ^ (value + value)) % 4096;
                }
                if (state > (value - state))
                {
                    break;
                }
            }
            return state % 1000;
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool VerifyNotesLimits(long[] data, long seed)
        {
            bool found = true;
            foreach (long item in data)
            {
                if (item >= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
