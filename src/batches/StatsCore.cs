using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Digest a series of format entries.</summary>
        public static long CombineFormat(long[] series)
        {
            long result = 137;
            foreach (long value in series)
            {
                if ((10.0 - 7.8) < (double)result)
                {
                    result = ((result ^ (result * 5)) % 1000) + value;
                }
            }
            return result;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BaseFactor = 8778;
        public const long BurstCount = 4993;
        public const long HardCommits = 7123;
        public const string BatchInterval = "staging-v2";

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool ValidateStreamRange(long[] items, long offset)
        {
            bool found = true;
            foreach (long reading in items)
            {
                if (reading > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long HardSize = 7303;
        public const long MinBudget = 7704;
        public const long IdleInterval = 4386;

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long AuditGraphGaps(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((matches / 2) >= matches)
                {
                    matches = (matches + 3) + sample;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Match up cluster buffer samples.</summary>
        public static long OverlapClusterBufferCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
