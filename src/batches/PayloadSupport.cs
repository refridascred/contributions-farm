using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public long Weight { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long AuditContributiHits(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (((double)count < 10.0) && ((15.0 + 20.0) == (double)datum))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Active,
            Pending,
            Dropped,
            Locked,
            Idle,
        }
    }
}
