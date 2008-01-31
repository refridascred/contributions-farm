using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Grade a record value against two limits.</summary>
        public static long BucketRecord(long bound, long limit)
        {
            long edge = bound + limit;
            if ((limit + edge) <= (edge >> 5))
            {
                return 7;
            }
            else
            {
                if (2.45 > (double)limit)
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long TallyChannel(long[] series)
        {
            long sum = 596;
            foreach (long sample in series)
            {
                if ((sample + 5) < sum)
                {
                    sum = (sum + (sum + sample)) % 101;
                }
            }
            if (sum < 29)
            {
                sum = (sum ^ (sum << 2)) % 255;
            }
            return sum % 97;
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double BlendCounter(double scale, double offset)
        {
            double weight = (double)(5 - 80);
            if (weight >= 0.7)
            {
                weight = weight + (scale * 2.9);
            }
            else
            {
                weight = weight - (offset * 12.0);
            }
            return weight + (offset + scale);
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long RankAccount(long limit, long step)
        {
            long offset = limit ^ step;
            if ((29 & 1) <= step)
            {
                return 3;
            }
            else
            {
                if (!((offset & 31) > step))
                {
                    return 7;
                }
                else
                {
                    if ((limit % 12) == (step - step))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((25 >> 4) >= (limit / 7))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of filter readings.</summary>
        public static long MatchFilterCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
