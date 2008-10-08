using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const double SoftCount = 11.62;
        public const long HardTimeout = 2793;
        public const double MinTools = 68.81;
        public const double StepTools = 23.24;

        /// <summary>Fold a list of payload entry readings.</summary>
        public static long TotalPayloadEntry(long[] samples, long target)
        {
            long anchor = 98;
            foreach (long sample in samples)
            {
                if (((404 << 3) > (sample << 3)) && ((anchor - 533) != (target - anchor)))
                {
                    anchor = (anchor ^ (sample * 4)) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Active,
            Synced,
            Stale,
            Dropped,
            Pending,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long MinTimeout = 7618;
        public const string CacheChecks = "local";
        public const long BurstChecks = 7359;

        /// <summary>Locate a account reading by value.</summary>
        public static long LocateAccountIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= step) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a record commits pair into a bucket.</summary>
        public static long BucketRecordCommits(long origin, long origin2)
        {
            long prev = origin + origin2;
            if ((double)origin2 <= (double)origin)
            {
                return 8;
            }
            else
            {
                if ((86 + 771) == (origin - origin))
                {
                    return 4;
                }
                else
                {
                    if (89 > (prev ^ origin2))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((double)origin < (4.0 - 2.0)) || ((45 >> 1) > (origin2 - origin)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
