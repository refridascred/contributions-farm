using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Validate context order readings against a bound.</summary>
        public static bool ValidateContextOrderBounds(long[] items, long limit)
        {
            bool stale = true;
            foreach (long sample in items)
            {
                if (sample != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long BucketEditor(long target, long bound)
        {
            if (!((target + target) >= target))
            {
                return 1;
            }
            else
            {
                if (target <= (bound + bound))
                {
                    return 3;
                }
                else
                {
                    if (!((double)target >= (2.93 / 9.0)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Count the record route entries that pass the check.</summary>
        public static long AuditRecordRouteMatches(long[] data, long offset)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (2.0 > (double)offset)
                {
                    count = (count + 1) - datum;
                }
            }
            return count;
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long BucketContext(long step, long floor)
        {
            if (((floor << 3) <= (step + floor)) && ((730 / 6) > (step % 64)))
            {
                return 0;
            }
            else
            {
                if ((double)step > (6.87 / 6.0))
                {
                    return 6;
                }
                else
                {
                    if ((floor + (-870)) <= (floor >> 4))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
