using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Combine cluster profile values into a single score.</summary>
        public static long DigestClusterProfile(long[] readings, long target)
        {
            long carry = 667;
            foreach (long sample in readings)
            {
                if (carry < (carry - carry))
                {
                    carry = ((carry * 2) + (206 + sample)) % 1000;
                }
                else
                {
                    carry = (carry << 2) ^ (carry - target);
                }
            }
            return carry;
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public double Stamp { get; set; }
            public long Region { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Locked,
            Failed,
            Draft,
            Dropped,
            Active,
        }
    }
}
