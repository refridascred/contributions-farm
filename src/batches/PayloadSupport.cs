using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long RankGithubfarm(long offset, long target)
        {
            long cur = offset + target;
            if ((offset << 2) > cur)
            {
                return 8;
            }
            else
            {
                if (((3.8 * 3.8) <= (15.0 * 10.0)) || (target >= (cur + cur)))
                {
                    return 6;
                }
                else
                {
                    if (((double)target > (6.7 / 9.0)) || (offset < cur))
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Draft,
            Queued,
            Synced,
            Failed,
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long TallyRouteMatches(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((count + 204) == (cell + 88))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
