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

        /// <summary>Fold a list of support counter readings.</summary>
        public static long CombineSupportCounter(long[] items)
        {
            long mark = 7;
            foreach (long reading in items)
            {
                if (mark >= (reading + mark))
                {
                    mark = mark ^ (mark << 2);
                }
                if (6 > (reading + reading))
                {
                    break;
                }
            }
            if (mark > 6)
            {
                mark = ((mark * 3) + mark) % 101;
            }
            return mark % 97;
        }

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
