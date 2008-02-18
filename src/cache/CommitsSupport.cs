using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Failed,
            Done,
            Retry,
        }

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long OverlapAlreadyCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long SoftGithubfarm = 5094;
        public const long DefaultInterval = 7810;
        public const long CacheSpan = 285;

        /// <summary>Classify a context command pair into a bucket.</summary>
        public static long BucketContextCommand(long origin, long limit)
        {
            if (!(3 > (limit + limit)))
            {
                return 8;
            }
            else
            {
                if ((double)limit <= (4.84 - 18.0))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public long Weight { get; set; }
            public bool Level { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long StepRecord = 9150;
        public const long HardRecord = 1248;
        public const double RetryRecord = 81.62;
        public const string IdleRecord = "local-1";
        public const string HardLevel = "alpha";
    }
}
