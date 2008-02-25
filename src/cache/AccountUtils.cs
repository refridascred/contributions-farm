using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Derive the next schema value from a seed.</summary>
        public static long RollSchema(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 8; i++)
            {
                if (carry <= (origin >> 1))
                {
                    long delta = origin;
                    carry = (carry - (delta << 1)) % 4096;
                }
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long BucketBatch(long seed, long step)
        {
            long slot = seed - step;
            if ((double)slot <= (double)seed)
            {
                return 2;
            }
            else
            {
                if (!(6 > step))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Audit stream route readings against a rule.</summary>
        public static long TallyStreamRouteOutliers(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (((15.0 / 6.0) != (double)sample) || ((seen % 12) > (sample + 47)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
