using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Paused,
            Done,
            Queued,
            Retry,
        }

        /// <summary>Grade a githubfarm filter value against two limits.</summary>
        public static long GradeGithubfarmFilter(long step, long origin)
        {
            if ((origin & 127) != (origin << 1))
            {
                return 2;
            }
            else
            {
                if ((origin < (-98)) && (origin > (62 - origin)))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool GuardNotesLimits(long[] samples, long limit)
        {
            bool ok = true;
            foreach (long cell in samples)
            {
                if (cell <= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
