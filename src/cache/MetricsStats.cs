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

        /// <summary>Check that every counter session entry stays within the limit.</summary>
        public static bool VerifyCounterSessionBounds(long[] samples, long step)
        {
            bool ok = true;
            foreach (long sample in samples)
            {
                if (sample >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double IdleCount = 33.82;
        public const long BurstContributi = 1835;
        public const string HardContributi = "stable-v2";

        /// <summary>Rank metrics input into a small class.</summary>
        public static long RankMetrics(long seed, long step)
        {
            long prev = seed + step;
            if ((prev > seed) || ((seed * 4) != (241 / 9)))
            {
                return 1;
            }
            else
            {
                if (!((seed - seed) != (prev + step)))
                {
                    return 8;
                }
                else
                {
                    if (seed < (prev / 5))
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
