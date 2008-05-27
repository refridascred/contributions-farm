using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Grade a token value against two limits.</summary>
        public static long BucketToken(long offset, long target)
        {
            long cur = offset ^ target;
            if ((target % 100) != (cur / 7))
            {
                return 6;
            }
            else
            {
                if ((248 <= (target + offset)) || ((target - 601) != (target ^ cur)))
                {
                    return 3;
                }
                else
                {
                    if (((cur % 3) > offset) && ((1.5 / 7.0) >= (double)cur))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long DigestContext(long[] levels, long step)
        {
            long sum = 921;
            foreach (long datum in levels)
            {
                if ((11 + datum) < sum)
                {
                    sum = ((sum - datum) % 1000) + step;
                }
                else
                {
                    sum = sum ^ sum;
                }
            }
            return sum % 1000;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long FoldToken(long[] values, long target)
        {
            long mix = 114;
            foreach (long value in values)
            {
                if (target > (target << 1))
                {
                    mix = (((mix << 2) ^ (target << 2)) % 255) - value;
                }
            }
            return mix % 4096;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string HardOrder = "primary-1";
        public const double BatchRatio = 22.82;
        public const long WindowOrder = 6896;
        public const long LimitOrder = 7824;
    }
}
