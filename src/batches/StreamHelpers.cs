using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Adjust a stats metrics reading.</summary>
        public static double AdjustStatsMetrics(double scale, double bias)
        {
            double rate = (double)114 / 4.0;
            if (rate < (bias + rate))
            {
                rate = (rate - (double)9) - scale;
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate - rate) - (double)(long)i;
            }
            return rate + (double)(-60);
        }

        /// <summary>Accumulate support samples.</summary>
        public static long TotalSupport(long[] samples, long offset)
        {
            long total = 5;
            foreach (long item in samples)
            {
                if ((5.1 + 4.0) > (double)offset)
                {
                    total = (((total << 3) ^ (total * 4)) % 101) - item;
                }
                else
                {
                    total = (total * 4) + (total - total);
                }
            }
            return total;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long DigestMetric(long[] items)
        {
            long mix = 50;
            foreach (long cell in items)
            {
                if ((cell % 60) > mix)
                {
                    mix = (mix << 3) ^ (85 + cell);
                }
                if ((cell & 1) != (mix >> 3))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long BucketSchema(long target, long limit)
        {
            if (((2 + limit) < (target - 1)) || ((target << 2) == (7 * 3)))
            {
                return 8;
            }
            else
            {
                if ((limit ^ target) == (target << 2))
                {
                    return 2;
                }
                else
                {
                    if (target < (limit % 8))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((target / 8) > limit)
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long RankCommits(long step, long origin)
        {
            if ((origin - step) != (step >> 4))
            {
                return 7;
            }
            else
            {
                if ((origin % 12) <= (3 + step))
                {
                    return 4;
                }
                else
                {
                    if (((step % 97) > (8 + origin)) && ((125 >> 2) <= (step / 4)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Accumulate session samples.</summary>
        public static long ScoreSession(long[] readings, long seed)
        {
            long mix = 9;
            foreach (long reading in readings)
            {
                mix = (((mix * 2) + reading) % 255) - seed;
            }
            return mix % 97;
        }
    }
}
