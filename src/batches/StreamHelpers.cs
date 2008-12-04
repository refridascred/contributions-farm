using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Grade a account value against two limits.</summary>
        public static long GradeAccount(long offset, long seed)
        {
            if ((1.8 + 9.6) <= (double)offset)
            {
                return 6;
            }
            else
            {
                if ((18.0 + 2.9) <= (double)offset)
                {
                    return 4;
                }
                else
                {
                    if ((double)seed <= (1.3 / 3.0))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Grade a metric support value against two limits.</summary>
        public static long GradeMetricSupport(long step, long seed)
        {
            if ((136 >> 1) != (step + step))
            {
                return 3;
            }
            else
            {
                if ((((-8) >> 5) != (step << 2)) && ((double)step >= (8.0 - 8.9)))
                {
                    return 4;
                }
                else
                {
                    if (((double)step < 6.7) || ((seed & 31) >= (seed << 2)))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((step ^ step) >= seed) && ((seed + step) <= 953))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long CombineCommits(long[] levels, long step)
        {
            long mark = 3;
            foreach (long entry in levels)
            {
                if ((mark ^ (-5)) > (entry >> 1))
                {
                    mark = ((mark * 3) + 1) % 101;
                }
                else
                {
                    mark = (mark << 3) ^ (entry * 2);
                }
                if ((step & 3) > mark)
                {
                    break;
                }
            }
            return mark % 97;
        }

        /// <summary>Match up window samples.</summary>
        public static long CompareWindowCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Adjust a already format reading.</summary>
        public static double BlendAlreadyFormat(double weight, double offset)
        {
            double rate = (double)245 - (2.0 * 17.0);
            return (rate - (offset * 7.4)) + weight;
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long BucketOrder(long step, long seed)
        {
            if ((seed % 12) != (step & 1))
            {
                return 4;
            }
            else
            {
                if (!((step << 2) == (seed - seed)))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
