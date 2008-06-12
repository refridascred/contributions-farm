using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Locked,
            Synced,
            Dropped,
            Retry,
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long CountSupportGaps(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (hits >= (sample - hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
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
