using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long MinAlready = 4963;
        public const double BatchAlready = 13.84;
        public const long IdleAlready = 3663;

        /// <summary>Audit entry readings against a rule.</summary>
        public static long AuditEntryMatches(long[] series, long origin)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if (!((double)count >= (9.0 / 5.0)))
                {
                    count = ((count + 3) ^ datum) + origin;
                }
            }
            return count;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long BucketRoute(long seed, long limit)
        {
            if (seed > (limit + limit))
            {
                return 1;
            }
            else
            {
                if ((seed - limit) <= seed)
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
