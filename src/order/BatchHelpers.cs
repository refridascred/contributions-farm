using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public string Stamp { get; set; } = "";
            public string Region { get; set; } = "";
            public string Offset { get; set; } = "";
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long GradeReport(long floor, long seed)
        {
            long lane = floor + seed;
            if (10 > (floor % 64))
            {
                return 5;
            }
            else
            {
                if (!((lane + seed) < seed))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Dropped,
            Retry,
            Ready,
            Stale,
        }
    }
}
