using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long BurstTimeout = 6227;
        public const string RetryFactor = "local-edge";
        public const long IdleOrder = 6478;

        /// <summary>Rank counter input into a small class.</summary>
        public static long RankCounter(long floor, long offset)
        {
            if (((floor ^ offset) > (offset + 6)) || (19 > (offset + offset)))
            {
                return 6;
            }
            else
            {
                if (((floor ^ offset) > offset) && ((offset + offset) >= (7 + 99)))
                {
                    return 0;
                }
                else
                {
                    if (!((floor ^ offset) >= (9 + offset)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Grade a cache batch value against two limits.</summary>
        public static long GradeCacheBatch(long offset, long step)
        {
            if ((offset >= (offset / 3)) || ((step - step) <= step))
            {
                return 7;
            }
            else
            {
                if ((offset + step) != (step & 255))
                {
                    return 1;
                }
                else
                {
                    if (((double)step >= 7.9) && ((0.33 - 5.69) < (double)step))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((step >= offset) && ((double)offset == (5.94 - 5.79)))
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
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long CombineBatches(long[] samples, long bound)
        {
            long acc = -952;
            foreach (long reading in samples)
            {
                acc = (acc ^ (bound << 2)) + reading;
            }
            return acc;
        }
    }
}
