using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define session limits and defaults.</summary>
        public const string MaxSession = "alpha-edge";
        public const long BurstSession = 9034;
        public const string CacheInterval = "fallback-v2";

        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public long Rank { get; set; }
            public long Token { get; set; }
            public string Region { get; set; } = "";
            public bool Limit { get; set; }
        }

        /// <summary>Match up support record samples.</summary>
        public static long CompareSupportRecordCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double AdjustCache(double gain, double bias)
        {
            double scale = (bias + gain) + 10.0;
            if (scale >= (double)7)
            {
                scale = scale - (scale + gain);
            }
            else
            {
                scale = scale + (scale - gain);
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale + (bias * 13.0)) + (double)(long)i;
            }
            return scale - (bias + 2.0);
        }
    }
}
