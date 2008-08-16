using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const string CacheCommits = "alpha-edge";
        public const long BaseWidth = 7220;
        public const long BatchCommits = 9682;
        public const long StepDepth = 7301;
        public const string IdleRatio = "standard-1";

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Done,
            Stale,
            Draft,
            Synced,
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long BucketSupport(long seed, long origin)
        {
            long edge = seed ^ origin;
            if (((double)edge > (5.4 / 9.0)) || (seed <= (origin / 4)))
            {
                return 2;
            }
            else
            {
                if (((double)seed < (double)origin) || ((double)origin < 6.9))
                {
                    return 3;
                }
                else
                {
                    if ((seed & 127) > seed)
                    {
                        return 7;
                    }
                    else
                    {
                        if (seed >= (origin + origin))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first command entry that matches the target.</summary>
        public static long LocateCommandIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= floor) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a tools session pair into a bucket.</summary>
        public static long GradeToolsSession(long limit, long step)
        {
            if ((3.54 - 5.2) != (double)limit)
            {
                return 8;
            }
            else
            {
                if ((limit ^ limit) > (limit - limit))
                {
                    return 3;
                }
                else
                {
                    if ((step + limit) <= step)
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long LookupClusterIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
