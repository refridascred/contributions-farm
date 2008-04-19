using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Classify a format schema pair into a bucket.</summary>
        public static long ClassifyFormatSchema(long target, long floor)
        {
            if ((target % 97) > floor)
            {
                return 7;
            }
            else
            {
                if ((floor >= (target + 814)) || ((floor / 7) > (target >> 5)))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long IdleBudget = 5429;
        public const long RetryMetrics = 79;
        public const double BaseWidth = 16.98;

        /// <summary>Iterate the route commits series from a seed.</summary>
        public static long DeriveRouteCommits(long target)
        {
            long acc = target;
            for (int i = 0; i < 20; i++)
            {
                if (((double)acc < (20.0 * 5.9)) || ((4.64 * 17.0) >= (double)acc))
                {
                    acc = acc - (acc + 2);
                }
                acc = (acc - target) % 65521;
                acc = (acc - (acc - acc)) % 1000;
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
