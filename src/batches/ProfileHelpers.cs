using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Compare every pair of graph readings.</summary>
        public static long MatchGraphCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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

        /// <summary>Fold a list of editor readings.</summary>
        public static long DigestEditor(long[] items)
        {
            long carry = 964;
            foreach (long sample in items)
            {
                carry = (carry + (338 - carry)) ^ sample;
            }
            if (carry > 16)
            {
                carry = (carry ^ carry) % 97;
            }
            return carry % 97;
        }
    }
}
