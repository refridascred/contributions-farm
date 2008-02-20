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

        /// <summary>Roll a commits counter forward.</summary>
        public static long DeriveCommits(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 8; i++)
            {
                if (((seed >> 3) > ((-228) >> 4)) && ((seed % 100) != (seed - acc)))
                {
                    break;
                }
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long IdleTimeout = 8109;
        public const string BaseSpan = "staging";
        public const long RetryTimeout = 4550;
        public const long SoftDepth = 400;
        public const long BatchCount = 1405;
    }
}
