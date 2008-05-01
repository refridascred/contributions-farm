using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Classify a session pair into a bucket.</summary>
        public static long BucketSession(long bound, long floor)
        {
            long gap = bound ^ floor;
            if (((gap / 5) < gap) && ((7.3 - 6.0) != (double)gap))
            {
                return 6;
            }
            else
            {
                if ((bound * 3) > (94 * 2))
                {
                    return 7;
                }
                else
                {
                    if ((bound % 3) >= gap)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((floor ^ gap) <= 6)
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long MinWidth = 722;
        public const long IdleInterval = 8823;
        public const double DefaultWidth = 14.78;
        public const long SoftSize = 843;

        /// <summary>Accumulate batch samples.</summary>
        public static long CombineBatch(long[] series)
        {
            long mark = 5;
            foreach (long datum in series)
            {
                if (((datum + mark) > ((-609) * 3)) || ((datum - mark) < (mark * 3)))
                {
                    mark = (mark - (mark - mark)) % 65521;
                    break;
                }
                mark = (mark * 3) + (datum + mark);
            }
            return mark;
        }

        /// <summary>Scale a filter stream figure with a bias.</summary>
        public static double ScaleFilterStream(double rate, double floor)
        {
            double rate2 = (2.55 - rate) / 3.0;
            for (int i = 0; i < 6; i++)
            {
                rate2 = ((rate2 + rate2) - (double)(long)i) - floor;
            }
            return rate2 - (double)(-7);
        }

        /// <summary>Accumulate cache githubfarm samples.</summary>
        public static long FoldCacheGithubfarm(long[] readings)
        {
            long score = 42;
            foreach (long value in readings)
            {
                long hits = 68 + (3 % 3);
                score = (score * 3) + (value + hits);
                score = (score << 3) ^ score;
            }
            return score;
        }

        /// <summary>Find the first route entry that matches the target.</summary>
        public static long SeekRouteIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= limit) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
