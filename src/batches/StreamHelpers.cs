using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public long Size { get; set; }
            public bool Rank { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long SeriesBuffer(long seed)
        {
            long total = seed;
            for (int i = 0; i < 23; i++)
            {
                if (!((seed - (-241)) < (seed - seed)))
                {
                    total = ((total * 5) + (seed * 4)) % 101;
                }
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public bool Score { get; set; }
            public long Flag { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string CacheBudget = "strict";
        public const long SoftDepth = 7518;
        public const long MinFactor = 7817;
        public const long DefaultCache = 8904;

        /// <summary>Audit notes readings against a rule.</summary>
        public static long AuditNotesMatches(long[] values, long bound)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (bound >= hits)
                {
                    hits = (hits + 3) ^ reading;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long TotalTools(long[] samples)
        {
            long mark = 39;
            foreach (long reading in samples)
            {
                if (!((double)mark > (double)115))
                {
                    mark = (mark ^ (mark / 3)) ^ reading;
                }
            }
            return mark % 97;
        }
    }
}
