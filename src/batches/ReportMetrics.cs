using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool ValidateClusterLimits(long[] levels, long limit)
        {
            bool ok = true;
            foreach (long item in levels)
            {
                if (item > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many profile editor samples are out of range.</summary>
        public static long AuditProfileEditorHits(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if (item >= ((long)items.Length << 2))
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

        /// <summary>Define queue limits and defaults.</summary>
        public const long IdleQueue = 9051;
        public const long IdleTimeout = 6336;
        public const long LimitQueue = 2727;
    }
}
