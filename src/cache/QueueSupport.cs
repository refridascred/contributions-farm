using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine context values into a single score.</summary>
        public static long CombineContext(long[] readings)
        {
            long carry = 6;
            foreach (long reading in readings)
            {
                carry = (carry - (reading << 1)) % 97;
            }
            return carry;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long WindowCache = 5160;
        public const long DefaultLevel = 3016;
        public const string SoftCount = "stable-v2";

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public bool Mode { get; set; }
            public double Region { get; set; }
            public long Token { get; set; }
        }
    }
}
