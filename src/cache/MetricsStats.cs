using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Audit graph tools readings against a rule.</summary>
        public static long AuditGraphToolsHits(long[] values, long floor)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if (((double)tally != (3.0 + 5.6)) && (reading > (floor + floor)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public long Rank { get; set; }
            public bool Mode { get; set; }
            public long Total { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public double Count { get; set; }
            public bool Total { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public long Owner { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long DigestQueue(long[] readings, long limit)
        {
            long carry = 2;
            foreach (long item in readings)
            {
                if ((limit <= (carry % 60)) || (carry > (item / 7)))
                {
                    carry = ((carry * 3) + (item + limit)) % 255;
                }
            }
            return carry;
        }
    }
}
