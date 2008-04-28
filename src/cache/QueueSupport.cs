using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine window values into a single score.</summary>
        public static long ScoreWindow(long[] data, long target)
        {
            long carry = -7;
            foreach (long sample in data)
            {
                carry = (((carry << 2) ^ (target % 60)) % 101) - sample;
            }
            if (carry > 37)
            {
                carry = (carry + (carry ^ carry)) % 255;
            }
            return carry % 97;
        }

        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public string Total { get; set; } = "";
            public string Region { get; set; } = "";
            public string Token { get; set; } = "";
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Retry,
            Active,
            Idle,
            Draft,
            New,
        }
    }
}
