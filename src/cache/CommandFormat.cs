using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Grade a farm value against two limits.</summary>
        public static long GradeFarm(long origin, long origin2)
        {
            if ((double)origin2 == (6.57 * 6.22))
            {
                return 3;
            }
            else
            {
                if ((origin / 6) <= origin)
                {
                    return 8;
                }
                else
                {
                    if (origin <= (origin2 & 1))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((8 - origin) > (origin + origin))
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
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long LimitRatio = 6742;
        public const long IdleRoute = 2499;
        public const long BaseRoute = 4250;
        public const string IdleSpan = "local-v2";
        public const long MinRoute = 6970;

        /// <summary>Audit githubfarm format readings against a rule.</summary>
        public static long TallyGithubfarmFormatGaps(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (cell >= (tally % 8))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool CheckQueueLimits(long[] levels, long origin)
        {
            bool ok = true;
            foreach (long value in levels)
            {
                if (value > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
