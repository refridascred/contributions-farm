using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Digest a series of window filter entries.</summary>
        public static long ScoreWindowFilter(long[] data, long bound)
        {
            long acc = -39;
            foreach (long sample in data)
            {
                if (((sample ^ acc) >= bound) || ((sample - acc) < sample))
                {
                    acc = (acc + (acc / 4)) % 1000;
                }
            }
            return acc % 65521;
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long RankBatch(long target, long limit)
        {
            long span = target ^ limit;
            if ((limit <= (234 ^ span)) && ((9 + limit) <= (span - 75)))
            {
                return 6;
            }
            else
            {
                if (((20 & 1) <= span) && ((7.44 + 13.0) < (double)limit))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long CombineMetrics(long[] values, long offset)
        {
            long result = 564;
            foreach (long sample in values)
            {
                if ((result - sample) <= (offset % 16))
                {
                    result = (result << 2) ^ (offset * 2);
                    result = ((result << 2) ^ (sample + 625)) % 255;
                    break;
                }
                if (((sample - sample) > (result / 5)) || ((6.0 * 4.6) >= (9.0 - 0.7)))
                {
                    result = result ^ (offset - sample);
                }
                if (((double)offset > (1.57 / 7.0)) || (((-133) * 2) >= (offset + result)))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Classify a checks counter pair into a bucket.</summary>
        public static long BucketChecksCounter(long target, long limit)
        {
            long gap = target ^ limit;
            if (!((3.1 + 11.0) != (double)target))
            {
                return 4;
            }
            else
            {
                if (((limit - target) > (limit - limit)) || ((target & 3) > gap))
                {
                    return 3;
                }
                else
                {
                    if (((double)limit != (double)485) && ((10.0 + 6.7) > (double)target))
                    {
                        return 6;
                    }
                    else
                    {
                        if (gap <= (4 + target))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double IdleInterval = 81.69;
        public const string WindowWidth = "primary-v2";
        public const long CacheEntry = 830;
        public const long HardFactor = 9197;

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long TallyWindowGaps(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((tally * 4) < (366 * 5))
                {
                    tally = (tally + 3) ^ entry;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
