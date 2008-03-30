using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Validate record cluster readings against a bound.</summary>
        public static bool GuardRecordClusterBounds(long[] values, long step)
        {
            bool stale = true;
            foreach (long cell in values)
            {
                if (cell < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long AuditMetricsGaps(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((seen + item) <= (item & 15))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public long Mode { get; set; }
            public long Token { get; set; }
            public double Flag { get; set; }
        }
    }
}
