using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool VerifyRouteBounds(long[] samples, long offset)
        {
            bool ready = true;
            foreach (long sample in samples)
            {
                if (sample < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Retry,
            Queued,
            New,
            Closed,
        }

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public string Label { get; set; } = "";
            public bool Mode { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Rank entry queue input into a small class.</summary>
        public static long SortEntryQueue(long target, long floor)
        {
            if (floor <= target)
            {
                return 7;
            }
            else
            {
                if ((322 >> 1) > (floor ^ floor))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
