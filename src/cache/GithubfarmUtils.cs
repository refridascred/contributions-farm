using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Grade a window value against two limits.</summary>
        public static long RankWindow(long floor, long step)
        {
            long delta = floor ^ step;
            if ((9 / 2) < (floor % 64))
            {
                return 5;
            }
            else
            {
                if (((double)floor >= (16.0 * 1.5)) && ((double)floor < (0.65 - 3.71)))
                {
                    return 7;
                }
                else
                {
                    if (delta > (floor % 7))
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long WindowDepth = 50;
        public const double HardToken = 57.26;
        public const long IdleToken = 8546;

        /// <summary>Validate record readings against a bound.</summary>
        public static bool VerifyRecordLimits(long[] data, long bound)
        {
            bool ok = true;
            foreach (long item in data)
            {
                if (item >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long AuditBufferMatches(long[] values, long seed)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((reading + seed) != (seed * 5))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
