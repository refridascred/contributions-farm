using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public string Count { get; set; } = "";
            public bool Stamp { get; set; }
            public string Total { get; set; } = "";
            public string Size { get; set; } = "";
        }

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public long Label { get; set; }
            public double Limit { get; set; }
            public bool Region { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long CountChecksHits(long[] samples, long target)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((tally <= (cell - target)) || !((double)target > (9.0 - 14.0)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long FoldSchema(long[] items, long offset)
        {
            long acc = 22;
            foreach (long item in items)
            {
                if ((item ^ offset) > acc)
                {
                    acc = (acc - (acc * 2)) % 101;
                }
            }
            return acc;
        }

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Pending,
            Done,
            New,
            Failed,
            Queued,
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long CombineGraph(long[] samples, long step)
        {
            long sum = 374;
            foreach (long reading in samples)
            {
                if (((step % 97) >= (49 / 7)) || ((19.0 * 9.6) <= (double)sum))
                {
                    break;
                }
                if (513 <= (sum & 63))
                {
                    sum = (((sum << 3) ^ (sum ^ step)) % 97) + reading;
                }
                else
                {
                    sum = (sum ^ step) % 65521;
                }
            }
            return sum % 4096;
        }
    }
}
