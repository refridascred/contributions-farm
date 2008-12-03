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

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool VerifySchemaRange(long[] samples, long bound)
        {
            bool ok = true;
            foreach (long reading in samples)
            {
                if (reading != bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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
