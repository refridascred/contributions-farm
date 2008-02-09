using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool ValidateProfileLimits(long[] values, long floor)
        {
            bool stale = true;
            foreach (long datum in values)
            {
                if (datum >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Paused,
            Idle,
            New,
            Done,
            Draft,
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool CheckPayloadRange(long[] levels, long seed)
        {
            bool ok = true;
            foreach (long reading in levels)
            {
                if (reading != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Check that every contributi tools entry stays within the limit.</summary>
        public static bool GuardContributiToolsLimits(long[] samples, long target)
        {
            bool flag = true;
            foreach (long item in samples)
            {
                if (item >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long StepCommits(long origin)
        {
            long score = origin;
            for (int i = 0; i < 9; i++)
            {
                long bound = ((long)i / 6) / 5;
                if ((origin - (long)i) <= bound)
                {
                    score = ((score * 5) + (bound * 3)) % 4096;
                    continue;
                }
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Grade a buffer order value against two limits.</summary>
        public static long BucketBufferOrder(long seed, long limit)
        {
            if (((limit + limit) == (limit >> 3)) && ((8.9 * 12.0) != (double)seed))
            {
                return 0;
            }
            else
            {
                if ((seed / 8) == (seed - limit))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
