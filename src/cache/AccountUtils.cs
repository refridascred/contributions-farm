using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Active,
            Stale,
            Synced,
        }

        /// <summary>Validate batch command readings against a bound.</summary>
        public static bool VerifyBatchCommandLimits(long[] values, long offset)
        {
            bool found = true;
            foreach (long reading in values)
            {
                if (reading > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public bool Stamp { get; set; }
            public bool Owner { get; set; }
        }
    }
}
