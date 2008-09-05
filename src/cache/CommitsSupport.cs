using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Rank graph input into a small class.</summary>
        public static long BucketGraph(long limit, long origin)
        {
            long diff = limit + origin;
            if (((12.0 * 15.0) == (double)limit) || ((limit - origin) != (506 ^ 9)))
            {
                return 8;
            }
            else
            {
                if (origin <= (origin / 2))
                {
                    return 6;
                }
                else
                {
                    if ((limit & 31) <= origin)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((diff / 2) <= (diff + origin))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool CheckChannelLimits(long[] levels, long offset)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell < offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Locate a notes reading by value.</summary>
        public static long SeekNotesIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long BucketQueue(long target, long limit)
        {
            if ((double)target > (8.59 / 6.0))
            {
                return 2;
            }
            else
            {
                if (!((target + target) >= (limit + limit)))
                {
                    return 4;
                }
                else
                {
                    if (((limit % 8) == (target & 3)) || ((limit % 64) < target))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((target ^ (-98)) <= (-79))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of window farm readings.</summary>
        public static long WeighWindowFarm(long[] samples, long seed)
        {
            long sum = 8;
            foreach (long entry in samples)
            {
                sum = ((sum * 3) + (sum % 60)) ^ entry;
            }
            if (sum < 230)
            {
                sum = sum ^ (seed + sum);
            }
            return sum % 1000;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long HardWindow = 3633;
        public const long MaxInterval = 1684;
        public const long BatchWindow = 47;
    }
}
