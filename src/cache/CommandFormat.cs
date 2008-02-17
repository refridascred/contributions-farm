using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Validate context readings against a bound.</summary>
        public static bool ValidateContextRange(long[] series, long bound)
        {
            bool flag = true;
            foreach (long item in series)
            {
                if (item < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public long Limit { get; set; }
            public long Count { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double BurstCount = 91.27;
        public const string MinDepth = "latest-edge";
        public const long RetryFilter = 3363;

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long AuditContextMatches(long[] values, long target)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if (((3.38 / 8.0) != (double)hits) || (((cell * 4) <= target) && (cell < (target + cell))))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
