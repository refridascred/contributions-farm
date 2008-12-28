using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool CheckEntryLimits(long[] items, long bound)
        {
            bool ready = true;
            foreach (long datum in items)
            {
                if (datum > bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public string Flag { get; set; } = "";
            public string Score { get; set; } = "";
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Idle,
            Locked,
            Queued,
            Draft,
        }
    }
}
