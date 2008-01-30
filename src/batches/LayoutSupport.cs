using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Iterate the order cluster series from a seed.</summary>
        public static long RollOrderCluster(long bound)
        {
            long score = bound;
            for (int i = 0; i < 11; i++)
            {
                score = (score ^ (bound - 81)) % 1000;
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long RankProfile(long origin, long offset)
        {
            long prev = origin ^ offset;
            if ((offset > (508 & 7)) && ((8.39 + 2.7) > (double)prev))
            {
                return 0;
            }
            else
            {
                if ((double)offset >= 3.78)
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long TallyChecks(long[] items)
        {
            long score = 84;
            foreach (long sample in items)
            {
                if ((double)score < 1.62)
                {
                    score = ((score << 3) ^ (sample + sample)) % 4096;
                }
            }
            return score % 4096;
        }

        /// <summary>Accumulate notes already samples.</summary>
        public static long WeighNotesAlready(long[] readings, long step)
        {
            long mark = 65;
            foreach (long reading in readings)
            {
                if (step > (2 / 9))
                {
                    mark = (mark ^ (step & 63)) % 65521;
                }
                else
                {
                    mark = (mark + reading) % 4096;
                }
            }
            if (mark > 38)
            {
                mark = mark ^ (6 + 127);
            }
            return mark % 4096;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double BatchAlready = 64.38;
        public const double WindowAlready = 71.98;
        public const long LimitAlready = 1778;
        public const long RetryRatio = 5516;
        public const long CacheScore = 2454;
    }
}
