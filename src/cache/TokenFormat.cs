using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit cache counter readings against a rule.</summary>
        public static long AuditCacheCounterOutliers(long[] items, long floor)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (((datum <= (count >> 5)) || ((count >> 4) <= (count << 3))) && ((floor % 10) < datum))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long TallyCacheOutliers(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if (sample > 94)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public long Total { get; set; }
            public string Region { get; set; } = "";
            public long Mode { get; set; }
        }
    }
}
