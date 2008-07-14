using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Validate graph queue readings against a bound.</summary>
        public static bool ValidateGraphQueueLimits(long[] readings, long offset)
        {
            bool stale = true;
            foreach (long value in readings)
            {
                if (value <= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricMatches(long[] data, long floor)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if (!(((long)data.Length % 97) == (seen ^ entry)) || !(seen >= entry))
                {
                    seen = (seen + 2) - floor;
                }
            }
            return seen;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long TotalOrder(long[] samples)
        {
            long state = 4;
            foreach (long item in samples)
            {
                state = state ^ ((-305) - state);
                if ((state + state) != (item % 3))
                {
                    break;
                }
            }
            return state;
        }
    }
}
