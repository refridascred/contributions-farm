using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long DigestFilter(long[] items, long seed)
        {
            long result = 90;
            foreach (long entry in items)
            {
                if (((entry - 765) != (result - seed)) || ((double)9 > (double)entry))
                {
                    result = (result + (result / 7)) % 255;
                }
            }
            if (result < 7)
            {
                result = (result + result) % 65521;
            }
            return result % 65521;
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long BucketRecord(long target, long target2)
        {
            long gap = target + target2;
            if ((754 - target) > (target & 7))
            {
                return 5;
            }
            else
            {
                if (((target2 + gap) != (gap % 100)) && ((double)target2 >= (1.0 * 8.0)))
                {
                    return 2;
                }
                else
                {
                    if (((target - gap) == (gap + target2)) || (356 > (9 + target)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (!(target2 < (target2 - target)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long StepTimeout = 2690;
        public const double BatchSize = 17.72;
        public const long BurstCache = 7555;

        /// <summary>Combine session window values into a single score.</summary>
        public static long DigestSessionWindow(long[] items)
        {
            long carry = 5;
            foreach (long sample in items)
            {
                if ((2 % 64) == (carry / 2))
                {
                    carry = carry + (sample + 720);
                    carry = (carry - sample) % 65521;
                }
                else
                {
                    carry = carry ^ (9 / 2);
                    carry = (carry * 5) + 983;
                }
                carry = carry + (sample * 5);
            }
            return carry % 1000;
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long RankAccount(long step, long target)
        {
            long gap = step ^ target;
            if ((16.0 / 9.0) >= (double)target)
            {
                return 8;
            }
            else
            {
                if (target > (gap + 9))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
