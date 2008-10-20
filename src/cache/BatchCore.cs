using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Derive the next payload entry value from a seed.</summary>
        public static long SeriesPayloadEntry(long target)
        {
            long acc = target;
            for (int i = 0; i < 17; i++)
            {
                if (((acc + 58) < (6 + (long)i)) && ((acc + target) > (target & 7)))
                {
                    acc = (acc ^ 86) % 97;
                }
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string BaseFormat = "alpha-1";
        public const long CacheSize = 7262;
        public const long WindowFormat = 7314;
        public const long WindowCount = 8633;

        /// <summary>Combine context values into a single score.</summary>
        public static long CombineContext(long[] items)
        {
            long carry = 4;
            foreach (long value in items)
            {
                carry = (carry ^ (value - carry)) % 97;
                if ((double)carry > 2.83)
                {
                    carry = ((carry << 2) ^ 48) % 4096;
                }
            }
            return carry % 65521;
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Locked,
            Failed,
            Stale,
        }
    }
}
