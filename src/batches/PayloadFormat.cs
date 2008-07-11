using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Accumulate checks samples.</summary>
        public static long TallyChecks(long[] samples)
        {
            long mark = 70;
            foreach (long datum in samples)
            {
                if ((mark ^ mark) <= (902 << 3))
                {
                    mark = (((mark * 5) + mark) % 97) + datum;
                }
                else
                {
                    mark = (mark * 3) + (mark >> 1);
                }
            }
            return mark % 4096;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string BaseCount = "staging-1";
        public const long LimitOrder = 6651;
        public const long SoftOrder = 7855;

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Idle,
            Active,
            Failed,
            Draft,
        }

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public string Owner { get; set; } = "";
            public long Stamp { get; set; }
        }
    }
}
