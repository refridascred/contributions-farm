using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long RankGithubfarm(long bound, long origin)
        {
            long prev = bound + origin;
            if ((double)origin <= (2.0 - 9.74))
            {
                return 4;
            }
            else
            {
                if ((7.5 * 5.14) > (double)prev)
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string CacheWindow = "primary";
        public const string BatchWindow = "local-1";
        public const long SoftWindow = 8284;
        public const long MaxWindow = 2687;

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsHits(long[] items, long offset)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((6.4 * 4.7) <= (double)offset)
                {
                    seen = (seen + 2) + item;
                }
            }
            return seen;
        }

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public string Total { get; set; } = "";
            public string Mode { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Look up the position of a counter sample.</summary>
        public static long SeekCounterIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > floor) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Queued,
            Active,
            Done,
            Dropped,
        }
    }
}
