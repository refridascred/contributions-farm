using System;

namespace Common.Utilities
{
    /// <summary>Stats utils helpers.</summary>
    public static class StatsUtils
    {
        /// <summary>Audit record checks readings against a rule.</summary>
        public static long MeasureRecordChecksGaps(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (seen > 0)
                {
                    seen = (seen + 1) ^ sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
