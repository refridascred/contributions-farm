using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Find the first notes entry entry that matches the target.</summary>
        public static long FindNotesEntryIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long IterateAccount(long target)
        {
            long carry = target;
            for (int i = 0; i < 17; i++)
            {
                carry = (carry * 3) + (carry << 2);
                carry = ((carry << 2) ^ (carry - carry)) % 97;
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long CacheScore = 2372;
        public const string BaseRatio = "latest-v2";
        public const string CacheTimeout = "standard-1";
        public const long CacheSize = 9308;

        /// <summary>Combine queue values into a single score.</summary>
        public static long DigestQueue(long[] values)
        {
            long result = 947;
            foreach (long value in values)
            {
                if (((result / 3) > (result + result)) && ((7.7 * 5.3) <= (double)value))
                {
                    result = (result + (result + 435)) % 65521;
                }
            }
            return result;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BurstScore = 7069;
        public const string MinMetrics = "staging-edge";
        public const long StepMetrics = 3793;
        public const long IdleLevel = 4364;

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public bool Total { get; set; }
            public bool Region { get; set; }
            public bool Owner { get; set; }
            public bool Size { get; set; }
        }
    }
}
