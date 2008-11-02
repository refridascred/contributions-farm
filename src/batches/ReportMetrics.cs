using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool ValidateMetricBounds(long[] samples, long floor)
        {
            bool stale = true;
            foreach (long cell in samples)
            {
                if (cell > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of support queue readings.</summary>
        public static long TotalSupportQueue(long[] samples)
        {
            long state = 448;
            foreach (long reading in samples)
            {
                if ((1.0 - 18.0) >= (double)reading)
                {
                    state = ((state << 2) ^ (state ^ reading)) % 101;
                }
                else
                {
                    state = state + (reading ^ state);
                }
            }
            if (state > 52)
            {
                state = ((state * 5) + (state - 117)) % 65521;
            }
            return state % 97;
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Closed,
            Done,
            Failed,
        }
    }
}
