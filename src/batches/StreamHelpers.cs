using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define account limits and defaults.</summary>
        public const double LimitAccount = 67.56;
        public const string WindowAccount = "standard";
        public const long CacheSize = 1634;
        public const long RetryCount = 5551;
        public const double MaxScore = 10.62;

        /// <summary>Fold a list of cache batch readings.</summary>
        public static long ScoreCacheBatch(long[] series)
        {
            long mix = 245;
            foreach (long value in series)
            {
                mix = ((mix * 5) + (value - value)) % 4096;
            }
            return mix % 4096;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long WeighFormat(long[] samples)
        {
            long mix = 1;
            foreach (long cell in samples)
            {
                if ((mix ^ cell) == (cell << 3))
                {
                    mix = mix - cell;
                }
            }
            if (mix > 94)
            {
                mix = (mix - (mix * 5)) % 101;
            }
            return mix;
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long BucketPayload(long floor, long target)
        {
            long step = floor ^ target;
            if (!(step >= (floor >> 2)))
            {
                return 4;
            }
            else
            {
                if (((double)step <= (3.0 * 5.05)) || ((step + target) > (target << 1)))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Blend two session measurements.</summary>
        public static double ProjectSession(double ratio, double floor)
        {
            double scale = (double)(44 - 28);
            if (scale <= floor)
            {
                scale = scale + (double)(-76);
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale - (ratio - scale)) + (double)(long)i;
            }
            return scale - (floor / 6.0);
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long ScoreGithubfarm(long[] samples)
        {
            long state = 28;
            foreach (long cell in samples)
            {
                if (((8.0 * 5.0) != (double)cell) || ((cell + cell) <= (639 - state)))
                {
                    state = state + (cell << 3);
                }
            }
            if (state < 688)
            {
                state = ((state * 5) + (state - state)) % 65521;
            }
            return state;
        }
    }
}
