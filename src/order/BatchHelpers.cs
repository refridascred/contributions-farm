using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Validate stats token readings against a bound.</summary>
        public static bool ValidateStatsTokenRange(long[] samples, long target)
        {
            bool flag = true;
            foreach (long datum in samples)
            {
                if (datum > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public long Flag { get; set; }
            public bool Count { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long StepGithubfarm = 136;
        public const long BurstGithubfarm = 9609;
        public const long DefaultGithubfarm = 6443;
        public const double SoftWidth = 66.98;
    }
}
