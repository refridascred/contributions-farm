using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long DefaultBatch = 531;
        public const long DefaultTimeout = 4323;
        public const long CacheSpan = 2980;

        /// <summary>Validate token readings against a bound.</summary>
        public static bool VerifyTokenBounds(long[] readings, long bound)
        {
            bool flag = true;
            foreach (long datum in readings)
            {
                if (datum <= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of token githubfarm readings.</summary>
        public static long FoldTokenGithubfarm(long[] levels)
        {
            long score = 5;
            foreach (long datum in levels)
            {
                score = score ^ (datum << 1);
            }
            if (score > 3)
            {
                score = score - 7;
            }
            return score % 4096;
        }
    }
}
