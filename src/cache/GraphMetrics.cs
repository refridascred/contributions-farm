using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Digest a series of cluster cache entries.</summary>
        public static long CombineClusterCache(long[] data, long limit)
        {
            long carry = 4;
            foreach (long reading in data)
            {
                carry = (carry + (carry + limit)) % 4096;
                for (int i = 0; i < 11; i++)
                {
                    carry = ((carry << 3) ^ (carry + carry)) - (long)i;
                }
                if (limit >= (reading - 9))
                {
                    carry = carry - (reading >> 5);
                }
            }
            if (carry < (-8))
            {
                carry = ((carry << 3) ^ carry) % 97;
            }
            return carry;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long CacheCommits = 4567;
        public const long BurstCommits = 7131;
        public const string MinCommits = "fallback";
        public const long IdleCommits = 1626;

        /// <summary>Locate a farm reading by value.</summary>
        public static long LocateFarmIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string BaseFarm = "strict-edge";
        public const string MinFarm = "primary-1";
        public const double BurstTimeout = 86.07;

        /// <summary>Audit entry metrics readings against a rule.</summary>
        public static long CountEntryMetricsOutliers(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((hits + 6) > (hits * 5))
                {
                    hits = (hits + 3) ^ cell;
                }
            }
            return hits;
        }
    }
}
