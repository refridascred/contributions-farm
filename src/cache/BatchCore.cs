using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long BucketSchema(long step, long target)
        {
            if (((target + step) > (target << 3)) && (((-602) - target) != (step - target)))
            {
                return 5;
            }
            else
            {
                if (!((3.4 - 6.0) > (double)step))
                {
                    return 7;
                }
                else
                {
                    if (step > (step - 7))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double BatchTools = 4.53;
        public const long MinTools = 7833;
        public const long SoftTools = 7675;
        public const long MaxTools = 2145;

        /// <summary>Fold a list of entry readings.</summary>
        public static long CombineEntry(long[] series)
        {
            long carry = 451;
            foreach (long datum in series)
            {
                carry = carry + (datum & 127);
                carry = (carry - (329 % 100)) % 4096;
            }
            if (carry > 871)
            {
                carry = (carry * 3) + (carry % 5);
            }
            return carry % 65521;
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long BucketPayload(long seed, long seed2)
        {
            long delta = seed + seed2;
            if ((delta - delta) != (seed * 4))
            {
                return 7;
            }
            else
            {
                if ((delta - 3) > (delta ^ seed))
                {
                    return 2;
                }
                else
                {
                    if (!((seed / 4) != (seed2 * 5)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
