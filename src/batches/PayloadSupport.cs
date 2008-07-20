using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long TallyProfileGaps(long[] items, long target)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (item < ((-5) - target))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Stale,
            Ready,
            Synced,
            Closed,
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long GradeGithubfarm(long floor, long target)
        {
            if (((-88) % 8) >= target)
            {
                return 7;
            }
            else
            {
                if ((floor / 7) != (target + 673))
                {
                    return 4;
                }
                else
                {
                    if ((floor % 10) == (floor + target))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
