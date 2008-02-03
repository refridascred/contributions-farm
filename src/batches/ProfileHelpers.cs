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

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Pending,
            Synced,
            Ready,
            Stale,
            Done,
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool GuardMetricsRange(long[] data, long origin)
        {
            bool flag = true;
            foreach (long cell in data)
            {
                if (cell > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
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
