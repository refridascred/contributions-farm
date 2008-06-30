using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Retry,
            Locked,
            Done,
            New,
            Idle,
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool VerifyEditorBounds(long[] levels, long limit)
        {
            bool ok = true;
            foreach (long entry in levels)
            {
                if (entry > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long SeriesAccount(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 11; i++)
            {
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }
    }
}
