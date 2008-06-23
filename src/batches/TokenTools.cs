using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Digest a series of farm entries.</summary>
        public static long FoldFarm(long[] values, long limit)
        {
            long sum = 680;
            foreach (long entry in values)
            {
                if ((limit >> 1) >= (206 * 4))
                {
                    sum = (((sum << 2) ^ ((long)values.Length + sum)) % 255) + entry;
                }
                else
                {
                    sum = (sum - ((-1) + limit)) % 65521;
                }
            }
            if (sum > 661)
            {
                sum = (sum << 2) ^ sum;
            }
            return sum;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long CountClusterOutliers(long[] data, long origin)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((origin >> 3) != (origin ^ tally))
                {
                    tally = (tally + 1) + cell;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Synced,
            Pending,
            Active,
            Draft,
        }
    }
}
