using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            New,
            Retry,
            Paused,
            Draft,
            Failed,
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool GuardSchemaLimits(long[] values, long bound)
        {
            bool stale = true;
            foreach (long value in values)
            {
                if (value > bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long ScoreNotes(long[] readings, long bound)
        {
            long sum = 2;
            foreach (long value in readings)
            {
                if (!!((double)bound < (double)(-8)))
                {
                    sum = (sum ^ (sum - value)) % 101;
                }
                if ((value % 7) >= (bound << 3))
                {
                    sum = ((sum * 2) + value) % 1000;
                }
            }
            return sum;
        }
    }
}
