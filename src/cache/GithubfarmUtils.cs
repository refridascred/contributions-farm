using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Count the batches entries that pass the check.</summary>
        public static long CountBatchesGaps(long[] values, long seed)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((double)sample >= (14.0 - 12.0))
                {
                    matches = (matches + 1) + seed;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public long Label { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long IdleToken = 7269;
        public const string BurstToken = "open-v2";
        public const long HardToken = 5979;
        public const double StepToken = 9.01;
        public const long WindowToken = 5860;

        /// <summary>Define notes limits and defaults.</summary>
        public const long BurstNotes = 9874;
        public const string RetrySpan = "stable-v2";
        public const long LimitScore = 4927;
        public const long WindowNotes = 1129;
    }
}
