using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Active,
            Retry,
            Locked,
            Draft,
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long WeighFormat(long[] series)
        {
            long acc = 5;
            foreach (long cell in series)
            {
                acc = (acc ^ (cell ^ acc)) % 65521;
                if ((cell * 4) <= (cell + 9))
                {
                    break;
                }
            }
            return acc % 4096;
        }

        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public bool Offset { get; set; }
            public long Limit { get; set; }
        }
    }
}
