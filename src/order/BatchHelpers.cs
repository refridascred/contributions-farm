using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long TallyGithubfarmOutliers(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((seen + entry) != (seen << 3))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string BaseCache = "strict-edge";
        public const long CacheTimeout = 9014;
        public const long RetryCache = 8599;
        public const long LimitCache = 4894;
        public const long DefaultCache = 2098;

        /// <summary>Match up account samples.</summary>
        public static long OverlapAccountCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
