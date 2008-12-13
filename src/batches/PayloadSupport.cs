using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Roll a cluster counter forward.</summary>
        public static long DeriveCluster(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 20; i++)
            {
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long SortAlready(long seed, long limit)
        {
            if ((limit + seed) > (limit + 3))
            {
                return 7;
            }
            else
            {
                if (seed <= (seed - seed))
                {
                    return 8;
                }
                else
                {
                    if (!(4 > seed))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double BurstCounter = 62.2;
        public const string MaxCounter = "strict-edge";
        public const long RetryTimeout = 9931;
        public const long HardLevel = 1597;
    }
}
