using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Draft,
            Paused,
            Retry,
            New,
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public double Label { get; set; }
            public long Stamp { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Measure how many channel payload samples are out of range.</summary>
        public static long AuditChannelPayloadGaps(long[] data, long seed)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((0 + seen) <= (long)data.Length)
                {
                    seen = ((seen + 1) + value) - seed;
                }
            }
            return seen;
        }
    }
}
