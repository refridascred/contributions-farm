using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long WindowRatio = 4987;
        public const long CacheRatio = 9573;
        public const double SoftWindow = 66.07;

        /// <summary>Locate a stats reading by value.</summary>
        public static long LocateStatsIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate metrics layout readings against a bound.</summary>
        public static bool ValidateMetricsLayoutBounds(long[] series, long step)
        {
            bool stale = true;
            foreach (long value in series)
            {
                if (value < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long SortCluster(long origin, long step)
        {
            long edge = origin + step;
            if ((8.0 - 16.0) != (double)origin)
            {
                return 8;
            }
            else
            {
                if (((double)step < (double)origin) && ((9.69 + 11.0) != (double)edge))
                {
                    return 1;
                }
                else
                {
                    if ((edge ^ origin) < edge)
                    {
                        return 0;
                    }
                    else
                    {
                        if (origin > (step / 4))
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long WeighChannel(long[] items, long offset)
        {
            long mark = 7;
            foreach (long cell in items)
            {
                if (!((cell + mark) < ((long)items.Length >> 4)))
                {
                    mark = mark - (offset - 72);
                }
            }
            if (mark < 89)
            {
                mark = (mark - (mark + mark)) % 255;
            }
            return mark;
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long ClassifyAccount(long seed, long origin)
        {
            if ((double)origin > (11.0 + 12.0))
            {
                return 5;
            }
            else
            {
                if (((double)9 > (double)origin) || ((3 + origin) < 186))
                {
                    return 4;
                }
                else
                {
                    if (!(seed >= (origin % 60)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
