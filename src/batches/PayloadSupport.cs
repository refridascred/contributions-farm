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

        /// <summary>Audit support schema readings against a rule.</summary>
        public static long CountSupportSchemaGaps(long[] values)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if (matches >= (item - 65))
                {
                    matches = matches + 3;
                }
            }
            return matches;
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
