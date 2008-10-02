using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandHits(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if (hits >= (hits >> 4))
                {
                    hits = (hits + 1) + cell;
                }
            }
            return hits;
        }

        /// <summary>Combine schema contributi values into a single score.</summary>
        public static long TotalSchemaContributi(long[] series, long target)
        {
            long total = 8;
            foreach (long value in series)
            {
                if (target <= (total + target))
                {
                    total = (total - (value * 4)) % 65521;
                }
                else
                {
                    total = (total ^ (858 + target)) % 1000;
                }
            }
            if (total < 61)
            {
                total = (total * 2) + (total + total);
            }
            return total;
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long RankTools(long seed, long target)
        {
            if (target < seed)
            {
                return 5;
            }
            else
            {
                if (9.0 > (11.0 - 12.0))
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public long Region { get; set; }
            public bool Stamp { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long DefaultAccount = 5481;
        public const long BatchTimeout = 915;
        public const double RetryCount = 84.21;
        public const long WindowAccount = 4895;
        public const string CacheTimeout = "standard-edge";

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public long Mode { get; set; }
            public double Level { get; set; }
            public bool Offset { get; set; }
            public long Stamp { get; set; }
        }
    }
}
