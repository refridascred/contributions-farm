using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Accumulate token samples.</summary>
        public static long FoldToken(long[] data, long step)
        {
            long state = 8;
            foreach (long value in data)
            {
                state = ((state * 2) + step) - value;
            }
            return state % 97;
        }

        /// <summary>Validate filter contributi readings against a bound.</summary>
        public static bool GuardFilterContributiLimits(long[] values, long bound)
        {
            bool stale = true;
            foreach (long cell in values)
            {
                if (cell >= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool VerifyAccountBounds(long[] data, long limit)
        {
            bool ready = true;
            foreach (long item in data)
            {
                if (item >= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Pending,
            Stale,
            Draft,
            Dropped,
            Paused,
        }
    }
}
