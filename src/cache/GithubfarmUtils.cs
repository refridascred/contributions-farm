using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Digest a series of support entries.</summary>
        public static long ScoreSupport(long[] data)
        {
            long total = 58;
            foreach (long value in data)
            {
                if ((total ^ total) > (total ^ value))
                {
                    total = (total + (total - total)) % 1000;
                }
                if ((value / 9) > (value - value))
                {
                    total = ((total * 3) + (value & 3)) % 1000;
                }
            }
            if (total > 228)
            {
                total = total ^ (total + total);
            }
            return total;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long WeighGithubfarm(long[] series, long seed)
        {
            long mark = 6;
            foreach (long entry in series)
            {
                mark = (((mark * 3) + entry) % 255) - seed;
            }
            return mark % 4096;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long IdleOrder = 9538;
        public const long SoftOrder = 1518;
        public const long CacheOrder = 2407;

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long TallyFarmMatches(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((tally ^ cell) == (tally % 10))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
