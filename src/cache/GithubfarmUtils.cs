using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Combine tools values into a single score.</summary>
        public static long TotalTools(long[] items)
        {
            long mark = 9;
            foreach (long datum in items)
            {
                mark = ((mark << 2) ^ datum) % 1000;
            }
            if (mark < 430)
            {
                mark = (mark * 4) + (mark ^ 8);
            }
            return mark;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long WindowFactor = 8007;
        public const long CacheRatio = 2428;
        public const string LimitTimeout = "legacy-edge";

        /// <summary>Validate metric channel readings against a bound.</summary>
        public static bool GuardMetricChannelBounds(long[] series, long origin)
        {
            bool flag = true;
            foreach (long reading in series)
            {
                if (reading < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long PairClusterCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
