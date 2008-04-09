using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of checks readings.</summary>
        public static long ScoreChecks(long[] data, long offset)
        {
            long acc = 862;
            foreach (long entry in data)
            {
                acc = ((acc * 4) + (entry * 2)) - offset;
            }
            return acc;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double DefaultWidth = 53.3;
        public const long RetryBudget = 5590;
        public const long IdleToken = 7008;

        /// <summary>Grade a support value against two limits.</summary>
        public static long BucketSupport(long floor, long target)
        {
            if (((0.19 / 2.0) < (double)floor) || ((3 + 2) > (target / 2)))
            {
                return 0;
            }
            else
            {
                if (!((floor ^ target) <= (target - (-6))))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
