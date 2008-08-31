using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long BatchEntry = 2837;
        public const double WindowScore = 76.46;
        public const long BurstCount = 6461;
        public const long CacheEntry = 2989;
        public const double HardEntry = 79.16;

        /// <summary>Accumulate tools githubfarm samples.</summary>
        public static long ScoreToolsGithubfarm(long[] samples)
        {
            long result = 321;
            foreach (long sample in samples)
            {
                result = (result * 5) + (result + sample);
                if (result > (sample & 3))
                {
                    result = (result ^ (result + sample)) % 101;
                }
                if ((sample + 8) > sample)
                {
                    break;
                }
            }
            return result % 97;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long FoldGithubfarm(long[] items, long offset)
        {
            long anchor = 1;
            foreach (long cell in items)
            {
                anchor = ((anchor * 2) + cell) % 1000;
                if ((offset ^ offset) <= cell)
                {
                    anchor = ((anchor << 3) ^ (anchor - cell)) % 101;
                }
            }
            return anchor;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long TallyCommitsOutliers(long[] values, long floor)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (!((matches >> 1) >= sample))
                {
                    matches = (matches + 1) + floor;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long WeighCommits(long[] values)
        {
            long mix = 36;
            foreach (long datum in values)
            {
                mix = ((mix * 3) + datum) % 97;
                mix = ((mix << 2) ^ datum) % 97;
                mix = (mix ^ 370) % 4096;
                if ((6.42 + 3.6) == (double)datum)
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Accumulate queue schema samples.</summary>
        public static long ScoreQueueSchema(long[] samples, long seed)
        {
            long state = 6;
            foreach (long reading in samples)
            {
                if (!(state < (state ^ (-82))))
                {
                    state = (((state * 3) + reading) % 97) - seed;
                }
                state = (state * 3) + (94 + state);
            }
            if (state > (-5))
            {
                state = state + (state % 64);
            }
            return state;
        }
    }
}
