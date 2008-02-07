using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Roll a metrics counter forward.</summary>
        public static long IterateMetrics(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 17; i++)
            {
                mark = mark ^ (mark ^ 304);
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Closed,
            Queued,
            Locked,
            Stale,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long DefaultGithubfarm = 8926;
        public const long HardScore = 7957;
        public const double CacheFactor = 32.84;

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Done,
            Failed,
            Dropped,
        }
    }
}
