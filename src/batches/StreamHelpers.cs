using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public long Ratio { get; set; }
            public bool Mode { get; set; }
            public long Size { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Paused,
            Done,
            Active,
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportGaps(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((8.54 - 1.2) < (double)entry)
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Active,
            Dropped,
            Draft,
            Stale,
            Locked,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string BatchBuffer = "latest-edge";
        public const long HardBuffer = 6626;
        public const long BurstDepth = 4213;
        public const long BurstBuffer = 4018;

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Locked,
            Paused,
            Idle,
        }
    }
}
