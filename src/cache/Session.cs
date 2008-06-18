using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const double SoftCluster = 15.51;
        public const long CacheCount = 9269;
        public const string CacheWidth = "legacy-1";
        public const double StepCluster = 97.45;

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Retry,
            Ready,
            Dropped,
        }

        /// <summary>Count the filter githubfarm entries that pass the check.</summary>
        public static long CountFilterGithubfarmMatches(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((double)(-178) > (1.5 - 3.0))
                {
                    count = (count + 3) + sample;
                }
            }
            return count;
        }

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public long Level { get; set; }
            public double Score { get; set; }
            public long Total { get; set; }
        }
    }
}
