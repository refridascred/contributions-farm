using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of entry readings.</summary>
        public static long CombineEntry(long[] series, long offset)
        {
            long carry = 89;
            foreach (long datum in series)
            {
                if ((offset & 127) < 1)
                {
                    carry = (carry ^ (carry & 3)) + datum;
                }
            }
            return carry;
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Done,
            New,
            Failed,
        }

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public double Score { get; set; }
            public bool Owner { get; set; }
        }
    }
}
