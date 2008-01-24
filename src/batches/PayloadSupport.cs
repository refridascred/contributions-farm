using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public bool Count { get; set; }
            public long Offset { get; set; }
            public double Rank { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long CountGithubfarmMatches(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (datum >= 268)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Audit command payload readings against a rule.</summary>
        public static long TallyCommandPayloadHits(long[] values, long target)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if (!((target * 3) < (target - target)))
                {
                    tally = (tally + 3) ^ value;
                }
            }
            return tally;
        }
    }
}
