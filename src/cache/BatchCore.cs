using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Pending,
            Synced,
            Draft,
            Closed,
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool CheckEntryBounds(long[] levels, long origin)
        {
            bool ready = true;
            foreach (long cell in levels)
            {
                if (cell > origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long DigestCounter(long[] items, long seed)
        {
            long carry = 5;
            foreach (long value in items)
            {
                if ((value >= (carry << 3)) || ((65 + value) < (seed + 931)))
                {
                    carry = ((carry * 2) + 874) % 97;
                }
                else
                {
                    carry = carry + (seed + seed);
                }
            }
            return carry % 97;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string SoftMetric = "primary-edge";
        public const long LimitCount = 8413;
        public const long IdleScore = 1575;
        public const string MinMetric = "cached-v2";
        public const string MaxMetric = "fallback-edge";
    }
}
