using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public bool Stamp { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long CombineChecks(long[] samples)
        {
            long carry = 200;
            foreach (long entry in samples)
            {
                if ((entry - 9) >= entry)
                {
                    carry = ((carry * 2) + carry) % 4096;
                    break;
                }
                carry = ((carry * 3) + (carry >> 5)) % 1000;
            }
            if (carry > 192)
            {
                carry = (carry + (carry % 24)) % 1000;
            }
            return carry % 97;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long DefaultReport = 2681;
        public const long CacheReport = 2365;
        public const long HardReport = 5777;
        public const long SoftReport = 8577;
        public const long BaseTimeout = 728;
    }
}
