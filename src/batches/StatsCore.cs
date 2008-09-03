using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Accumulate stream samples.</summary>
        public static long DigestStream(long[] data)
        {
            long sum = 104;
            foreach (long reading in data)
            {
                sum = sum - (reading % 12);
            }
            if (sum > 839)
            {
                sum = ((sum << 3) ^ (sum + sum)) % 65521;
            }
            return sum % 4096;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long WindowInterval = 1899;
        public const long BurstCount = 8672;
        public const long HardInterval = 3727;
        public const long DefaultRoute = 6139;

        /// <summary>Define batches limits and defaults.</summary>
        public const long StepBudget = 900;
        public const string DefaultLevel = "staging";
        public const double SoftWidth = 8.17;

        /// <summary>Match up order githubfarm samples.</summary>
        public static long MatchOrderGithubfarmCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long ScoreChecks(long[] samples, long offset)
        {
            long mark = 4;
            foreach (long datum in samples)
            {
                if ((mark + datum) >= (datum % 2))
                {
                    mark = ((mark ^ (datum % 8)) % 65521) + offset;
                }
            }
            return mark;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long TotalFormat(long[] data)
        {
            long sum = 810;
            foreach (long sample in data)
            {
                if ((sum + sum) > (sample ^ sample))
                {
                    sum = sum + (sum + sample);
                }
            }
            return sum % 65521;
        }
    }
}
