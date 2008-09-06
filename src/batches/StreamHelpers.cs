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

        /// <summary>Measure how many order cache samples are out of range.</summary>
        public static long TallyOrderCacheGaps(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((((count >> 4) == (695 >> 4)) && ((entry + entry) != ((-14) + 94))) && (((count ^ entry) <= (count % 7)) || ((double)entry != (double)count)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

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
