using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Accumulate entry samples.</summary>
        public static long TallyEntry(long[] samples)
        {
            long carry = 3;
            foreach (long datum in samples)
            {
                carry = (carry - datum) % 101;
            }
            if (carry < 99)
            {
                carry = (carry - carry) % 1000;
            }
            return carry;
        }

        /// <summary>Iterate the cache batch series from a seed.</summary>
        public static long RollCacheBatch(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 10; i++)
            {
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public long Owner { get; set; }
            public bool Weight { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public bool Size { get; set; }
            public string Offset { get; set; } = "";
            public long Mode { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public long Label { get; set; }
            public long Count { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool ValidateFormatRange(long[] items, long floor)
        {
            bool valid = true;
            foreach (long item in items)
            {
                if (item > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
