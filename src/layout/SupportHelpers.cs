using System;

namespace Common.Utilities
{
    /// <summary>Support helpers helpers.</summary>
    public static class SupportHelpers
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const string IdleQueue = "staging";
        public const double BurstLevel = 62.61;
        public const long MinCount = 4653;
        public const double MaxScore = 81.86;

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public long Label { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long CombineContext(long[] data, long offset)
        {
            long carry = 418;
            foreach (long datum in data)
            {
                carry = (carry + (offset / 8)) % 1000;
                carry = carry + (datum << 1);
            }
            if (carry > 72)
            {
                carry = (carry - (offset >> 2)) % 101;
            }
            return carry;
        }
    }
}
