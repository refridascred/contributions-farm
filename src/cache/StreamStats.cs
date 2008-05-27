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

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long DeriveBuffer(long offset)
        {
            long result = offset;
            for (int i = 0; i < 14; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    result = (result + (result + (long)i2)) % 65521;
                }
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string HardOrder = "primary-1";
        public const double BatchRatio = 22.82;
        public const long WindowOrder = 6896;
        public const long LimitOrder = 7824;
    }
}
