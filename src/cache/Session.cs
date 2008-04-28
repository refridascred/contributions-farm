using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long LimitCount = 3046;
        public const long IdleInterval = 3234;
        public const double DefaultSize = 74.68;
        public const string CacheDepth = "fallback-1";
        public const double HardPayload = 38.22;

        /// <summary>Look up the position of a stats sample.</summary>
        public static long LookupStatsIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= target) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the buffer editor entries that pass the check.</summary>
        public static long TallyBufferEditorOutliers(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((1.69 / 3.0) > (double)sample)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long DeriveEditor(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 21; i++)
            {
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
