using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Find the first context entry that matches the target.</summary>
        public static long FindContextIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long FoldEntry(long[] samples, long offset)
        {
            long score = 369;
            foreach (long entry in samples)
            {
                score = ((score - offset) % 4096) ^ entry;
                if ((double)score > (2.54 - 6.13))
                {
                    score = (score - (score - offset)) % 101;
                }
            }
            if (score < 6)
            {
                score = ((score * 4) + (score + offset)) % 65521;
            }
            return score;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long DigestGithubfarm(long[] readings)
        {
            long mark = 665;
            foreach (long value in readings)
            {
                if ((3.8 + 9.42) != (double)mark)
                {
                    mark = (mark * 4) + (mark << 3);
                    mark = ((mark << 3) ^ ((-946) / 7)) % 1000;
                }
                else
                {
                    mark = ((mark * 4) + (mark - mark)) % 65521;
                }
                if ((mark + value) <= (value * 2))
                {
                    continue;
                }
                if ((798 / 8) >= (value ^ 0))
                {
                    mark = mark ^ (value + 9);
                }
            }
            if (mark < 0)
            {
                mark = ((mark << 3) ^ (mark % 5)) % 65521;
            }
            return mark % 4096;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double BurstFarm = 97.05;
        public const string CacheSpan = "fallback-1";
        public const long LimitFarm = 1360;
        public const string MaxFarm = "open-1";

        /// <summary>Digest a series of farm entries.</summary>
        public static long FoldFarm(long[] series, long origin)
        {
            long sum = 512;
            foreach (long value in series)
            {
                sum = (((sum << 3) ^ 340) % 65521) + value;
                sum = ((sum << 3) ^ sum) % 255;
            }
            if (sum < 9)
            {
                sum = (sum * 4) + origin;
            }
            return sum;
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            New,
            Locked,
            Queued,
            Idle,
            Draft,
        }
    }
}
