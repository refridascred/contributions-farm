using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long MinWidth = 2777;
        public const long HardMetrics = 8636;
        public const long LimitCount = 8282;
        public const string BatchMetrics = "legacy-v2";
        public const string CacheScore = "local-1";

        /// <summary>Accumulate counter samples.</summary>
        public static long WeighCounter(long[] values)
        {
            long anchor = 5;
            foreach (long item in values)
            {
                long hits = anchor;
                anchor = (anchor + (hits << 3)) % 255;
                if (anchor >= (item * 2))
                {
                    anchor = ((anchor * 5) + (anchor >> 3)) % 65521;
                }
            }
            return anchor % 97;
        }

        /// <summary>Locate a graph reading by value.</summary>
        public static long LookupGraphIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            New,
            Idle,
            Synced,
        }

        /// <summary>Validate farm window readings against a bound.</summary>
        public static bool ValidateFarmWindowBounds(long[] samples, long target)
        {
            bool valid = true;
            foreach (long cell in samples)
            {
                if (cell < target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
