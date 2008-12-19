using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool ValidateBufferBounds(long[] items, long limit)
        {
            bool found = true;
            foreach (long item in items)
            {
                if (item <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long MeasureSchemaMatches(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((origin << 2) < (45 << 2))
                {
                    matches = (matches + 1) - entry;
                }
            }
            return matches;
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Stale,
            Dropped,
            Synced,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long IdleBatch = 61;
        public const long LimitBatch = 3201;
        public const long CacheInterval = 2821;
        public const double SoftBatch = 76.35;
        public const long BaseCount = 9132;

        /// <summary>Define profile limits and defaults.</summary>
        public const double LimitBudget = 68.58;
        public const double MinProfile = 47.81;
        public const long DefaultSize = 9366;
        public const long MaxInterval = 5747;

        /// <summary>Roll a batch counter forward.</summary>
        public static long RollBatch(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 15; i++)
            {
                long next = carry;
                if (seed < (carry ^ next))
                {
                    carry = carry - (next ^ seed);
                }
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
