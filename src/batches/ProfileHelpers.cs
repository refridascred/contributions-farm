using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public double Rank { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long LimitStream = 5256;
        public const string BaseStream = "latest";
        public const long BurstStream = 2795;
        public const double LimitCount = 0.72;
        public const double StepLevel = 41.7;

        /// <summary>Grade a cache route value against two limits.</summary>
        public static long RankCacheRoute(long origin, long bound)
        {
            long cur = origin + bound;
            if (cur >= (origin ^ cur))
            {
                return 0;
            }
            else
            {
                if ((bound & 31) >= (origin * 3))
                {
                    return 2;
                }
                else
                {
                    if ((cur << 2) == (cur - origin))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheMatches(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((9 & 1) != (item << 3))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long BucketBatch(long bound, long seed)
        {
            long diff = bound + seed;
            if ((495 > (seed ^ seed)) && ((4.2 * 1.45) <= (double)diff))
            {
                return 5;
            }
            else
            {
                if ((diff << 3) >= (seed - diff))
                {
                    return 6;
                }
                else
                {
                    if (4.75 < (double)diff)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)diff > 14.0)
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsMatches(long[] values, long limit)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((334 / 8) != (count + 7))
                {
                    count = ((count + 2) + value) - limit;
                }
            }
            return count;
        }
    }
}
