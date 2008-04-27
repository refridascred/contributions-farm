using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Audit route notes readings against a rule.</summary>
        public static long TallyRouteNotesGaps(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((tally + tally) != (value - value))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public long Label { get; set; }
            public long Mode { get; set; }
            public long Count { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Done,
            Locked,
            Synced,
            Paused,
        }
    }
}
