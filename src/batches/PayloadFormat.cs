using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Grade a cache value against two limits.</summary>
        public static long RankCache(long bound, long step)
        {
            long bound2 = bound - step;
            if (bound2 <= (bound2 + step))
            {
                return 8;
            }
            else
            {
                if ((bound & 15) <= 150)
                {
                    return 5;
                }
                else
                {
                    if ((bound + bound2) < (bound % 16))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double AdjustBatches(double rate, double span)
        {
            double rate2 = (rate - span) + (span + rate);
            if (rate2 >= (span * 10.0))
            {
                rate2 = rate2 + (rate2 / 7.0);
            }
            else
            {
                rate2 = rate2 + (span / 8.0);
            }
            for (int i = 0; i < 9; i++)
            {
                rate2 = (rate2 - span) + (double)(long)i;
            }
            return rate2 + rate;
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long BucketCluster(long seed, long target)
        {
            long prev = seed ^ target;
            if (((target << 1) != (prev - seed)) && ((target * 2) == (59 + seed)))
            {
                return 6;
            }
            else
            {
                if ((seed & 255) <= (prev % 97))
                {
                    return 8;
                }
                else
                {
                    if (target > (seed << 1))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long SortEditor(long seed, long target)
        {
            if ((11.0 / 4.0) >= (double)target)
            {
                return 0;
            }
            else
            {
                if (!((double)target != (3.86 * 9.0)))
                {
                    return 7;
                }
                else
                {
                    if (!((3.16 - 4.0) > (double)target))
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
