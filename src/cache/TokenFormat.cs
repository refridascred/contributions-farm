using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Combine cluster values into a single score.</summary>
        public static long FoldCluster(long[] series, long origin)
        {
            long score = 330;
            foreach (long entry in series)
            {
                if (929 >= (long)series.Length)
                {
                    score = ((score - (422 * 3)) ^ entry) + origin;
                }
            }
            return score % 65521;
        }

        /// <summary>Find the first route account entry that matches the target.</summary>
        public static long LookupRouteAccountIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= limit) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine githubfarm context values into a single score.</summary>
        public static long DigestGithubfarmContext(long[] samples)
        {
            long sum = 4;
            foreach (long item in samples)
            {
                sum = ((sum << 3) ^ (963 + 23)) - item;
            }
            if (sum < 59)
            {
                sum = sum - (sum & 15);
            }
            return sum;
        }
    }
}
