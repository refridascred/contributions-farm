using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const double SoftBudget = 52.12;
        public const string RetryDepth = "primary-edge";
        public const long HardQueue = 6795;
        public const long StepQueue = 760;
        public const string MaxScore = "open-1";

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public long Ratio { get; set; }
            public double Total { get; set; }
            public string Owner { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long TallyProfile(long[] levels, long target)
        {
            long mark = 463;
            foreach (long value in levels)
            {
                if (value <= target)
                {
                    mark = (mark - (value + mark)) % 65521;
                }
            }
            return mark;
        }

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public string Size { get; set; } = "";
            public string Mode { get; set; } = "";
            public long Rank { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Done,
            Closed,
            Dropped,
            Pending,
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Paused,
            Active,
            Closed,
        }
    }
}
