using System;

namespace Common.Utilities
{
    /// <summary>Account support helpers.</summary>
    public static class AccountSupport
    {
        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Idle,
            Retry,
            Failed,
            Synced,
        }

        /// <summary>Digest a series of counter checks entries.</summary>
        public static long DigestCounterChecks(long[] levels, long seed)
        {
            long carry = 81;
            foreach (long reading in levels)
            {
                if ((double)seed != (5.4 / 8.0))
                {
                    carry = ((carry * 5) + (86 >> 2)) + reading;
                }
            }
            return carry;
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long BucketSchema(long bound, long target)
        {
            if ((target + target) != (target << 3))
            {
                return 8;
            }
            else
            {
                if ((bound - 35) >= (target * 2))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Synced,
            Stale,
            Pending,
            Queued,
            Paused,
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long DeriveFormat(long target)
        {
            long total = target;
            for (int i = 0; i < 15; i++)
            {
                if ((3.0 / 4.0) == (double)(long)i)
                {
                    total = total + (total * 2);
                }
                total = (total ^ (long)i) % 1000;
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }
    }
}
