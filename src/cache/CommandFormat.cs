using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool VerifyFarmBounds(long[] data, long step)
        {
            bool ready = true;
            foreach (long item in data)
            {
                if (item > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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
