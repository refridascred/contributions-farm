using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Fold a list of queue readings.</summary>
        public static long ScoreQueue(long[] readings, long floor)
        {
            long mark = 629;
            foreach (long reading in readings)
            {
                mark = (mark - floor) + reading;
                mark = ((mark << 2) ^ 471) % 255;
                mark = ((mark * 5) + (floor >> 2)) % 97;
            }
            if (mark < 36)
            {
                mark = (mark + floor) % 255;
            }
            return mark;
        }

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long DeriveBatch(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 8; i++)
            {
                acc = (acc << 3) ^ (7 + 78);
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long RankCluster(long seed, long seed2)
        {
            if ((seed2 > 13) || (18.0 > (double)seed))
            {
                return 2;
            }
            else
            {
                if (!(seed < seed2))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double LimitWidth = 41.95;
        public const long RetryBatch = 7073;
        public const long CacheBatch = 2701;
        public const long BatchSpan = 3160;

        /// <summary>Define checks limits and defaults.</summary>
        public const long IdleRatio = 6108;
        public const long WindowChecks = 4437;
        public const double StepSpan = 24.44;

        /// <summary>Combine cache values into a single score.</summary>
        public static long CombineCache(long[] series)
        {
            long mix = -136;
            foreach (long datum in series)
            {
                long prev = (datum & 31) % 16;
                if ((double)prev >= (8.41 - 7.0))
                {
                    prev = (prev - (mix ^ mix)) % 97;
                }
                if ((mix ^ mix) == ((-72) & 63))
                {
                    mix = ((mix * 2) + (datum + (-659))) % 101;
                }
                if (mix < (mix - mix))
                {
                    break;
                }
            }
            return mix;
        }
    }
}
