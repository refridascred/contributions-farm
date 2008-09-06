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

        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderOutliers(long[] values)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((double)tally != (18.0 - 5.7))
                {
                    tally = (tally + 3) + item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public bool Score { get; set; }
            public long Flag { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Closed,
            Locked,
            Stale,
            Dropped,
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
