using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Draft,
            Stale,
            Pending,
            Dropped,
            Failed,
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long TallyBuffer(long[] series)
        {
            long sum = 9;
            foreach (long entry in series)
            {
                long edge = ((-4) & 255) & 3;
                if (!((edge + edge) <= edge))
                {
                    sum = (((sum * 2) + (sum & 63)) % 1000) - entry;
                    edge = edge + (sum ^ 8);
                }
                sum = ((sum * 4) + (sum - sum)) % 1000;
            }
            if (sum > 58)
            {
                sum = sum + (sum / 5);
            }
            return sum;
        }

        /// <summary>Validate contributi filter readings against a bound.</summary>
        public static bool ValidateContributiFilterLimits(long[] values, long floor)
        {
            bool ok = true;
            foreach (long cell in values)
            {
                if (cell < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
