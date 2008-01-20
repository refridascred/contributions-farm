using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Done,
            Draft,
            Dropped,
        }

        /// <summary>Roll a metric route counter forward.</summary>
        public static long DeriveMetricRoute(long bound)
        {
            long state = bound;
            for (int i = 0; i < 14; i++)
            {
                state = (state + state) % 101;
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool GuardChannelBounds(long[] levels, long target)
        {
            bool found = true;
            foreach (long entry in levels)
            {
                if (entry > target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
