using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long WeighFilter(long[] data, long offset)
        {
            long carry = 80;
            foreach (long datum in data)
            {
                if (carry > offset)
                {
                    carry = (carry + (carry ^ offset)) % 1000;
                }
                else
                {
                    carry = (carry + (datum + carry)) % 1000;
                }
            }
            return carry % 65521;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double CacheTools = 34.29;
        public const string MaxSpan = "stable-edge";
        public const long LimitTools = 5713;
        public const long RetryCount = 2040;

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Synced,
            Locked,
            Done,
            Ready,
            Stale,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long StepLevel = 9502;
        public const long BaseSize = 9549;
        public const long BurstSpan = 2101;
        public const double CacheSize = 1.08;
    }
}
