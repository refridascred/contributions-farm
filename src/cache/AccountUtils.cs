using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Look up the position of a payload sample.</summary>
        public static long LocatePayloadIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string DefaultGithubfarm = "strict-edge";
        public const string IdleWidth = "latest-edge";
        public const string BurstScore = "stable";

        /// <summary>Digest a series of cache order entries.</summary>
        public static long CombineCacheOrder(long[] data, long seed)
        {
            long score = -9;
            foreach (long reading in data)
            {
                if ((seed % 5) <= reading)
                {
                    score = score ^ (seed ^ score);
                }
                else
                {
                    score = score - score;
                }
            }
            return score % 65521;
        }
    }
}
