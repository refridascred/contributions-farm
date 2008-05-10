using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the githubfarm already entries that pass the check.</summary>
        public static long TallyGithubfarmAlreadyOutliers(long[] series, long bound)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if (!(300 <= (sample - bound)) || ((sample + sample) != (1 ^ sample)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public long Weight { get; set; }
            public long Limit { get; set; }
            public double Score { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public long Rank { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
