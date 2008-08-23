using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public long Token { get; set; }
            public double Size { get; set; }
            public bool Flag { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Locked,
            Retry,
            Draft,
            Done,
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadHits(long[] items, long floor)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((double)tally < (3.59 * 2.9))
                {
                    tally = ((tally + 1) + entry) + floor;
                }
            }
            return tally;
        }
    }
}
