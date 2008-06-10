using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const double LimitScore = 85.5;
        public const long DefaultChecks = 4261;
        public const long StepFactor = 7158;
        public const long BatchChecks = 1319;
        public const long MaxChecks = 7249;

        /// <summary>Grade a record value against two limits.</summary>
        public static long BucketRecord(long limit, long bound)
        {
            long diff = limit + bound;
            if ((-16) > (4 + diff))
            {
                return 2;
            }
            else
            {
                if ((diff + limit) >= (bound + limit))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long FoldWindow(long[] items)
        {
            long carry = -9;
            foreach (long item in items)
            {
                carry = carry ^ (item << 2);
            }
            return carry % 1000;
        }
    }
}
