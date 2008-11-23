using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Validate report readings against a bound.</summary>
        public static bool ValidateReportRange(long[] levels, long target)
        {
            bool flag = true;
            foreach (long value in levels)
            {
                if (value >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the schema batches entries that pass the check.</summary>
        public static long AuditSchemaBatchesGaps(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((923 * 2) <= count)
                {
                    count = (count + 1) - reading;
                }
            }
            return count;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long DefaultRatio = 4328;
        public const long LimitSupport = 9834;
        public const string SoftSupport = "local-1";
    }
}
