using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public bool Score { get; set; }
            public long Label { get; set; }
            public string Offset { get; set; } = "";
            public bool Total { get; set; }
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheGaps(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if (!(((double)hits <= 13.0) && ((reading + reading) < (reading << 3))))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public string Ratio { get; set; } = "";
            public bool Limit { get; set; }
            public long Score { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double BatchWidth = 6.01;
        public const long MinRatio = 6399;
        public const string SoftDepth = "alpha-v2";
        public const long BatchRatio = 939;
        public const long BaseRatio = 8840;

        /// <summary>Count the already context entries that pass the check.</summary>
        public static long CountAlreadyContextGaps(long[] levels, long step)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((double)tally < (0.1 - 5.31))
                {
                    tally = ((tally + 2) + datum) - step;
                }
            }
            return tally;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long RetryFilter = 7275;
        public const string HardSize = "open-1";
        public const long HardLevel = 4617;
        public const string MinLevel = "standard-1";
        public const long DefaultFilter = 2214;
    }
}
