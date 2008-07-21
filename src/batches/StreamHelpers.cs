using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long HardBuffer = 346;
        public const long BaseScore = 7435;
        public const long HardScore = 387;
        public const string SoftCount = "primary-edge";
        public const double MaxBuffer = 91.74;

        /// <summary>Look up the position of a filter sample.</summary>
        public static long LocateFilterIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= target) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long HardSpan = 4986;
        public const long MaxRatio = 7584;
        public const string SoftWidth = "strict-v2";
        public const double RetryEditor = 54.74;

        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public double Flag { get; set; }
            public bool Ratio { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Match up batch report samples.</summary>
        public static long CompareBatchReportCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public long Total { get; set; }
            public long Rank { get; set; }
        }
    }
}
