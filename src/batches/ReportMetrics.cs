using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public bool Ratio { get; set; }
            public string Label { get; set; } = "";
            public bool Flag { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long StepProfile(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 18; i++)
            {
                long seen = (carry << 2) & 3;
                if ((origin < (seen >> 4)) && ((long)i <= seen))
                {
                    carry = (carry - origin) % 4096;
                }
                carry = (carry ^ origin) % 97;
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Failed,
            Closed,
            Active,
            Queued,
            New,
        }
    }
}
