using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const string BatchSpan = "staging-1";
        public const long BaseTimeout = 6303;
        public const long LimitRatio = 3387;
        public const double WindowDepth = 75.99;
        public const long RetrySchema = 4618;

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
