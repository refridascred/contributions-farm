using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Locked,
            New,
            Paused,
            Active,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string BatchSpan = "stable-edge";
        public const long BaseCommand = 5313;
        public const long MaxCommand = 8656;
        public const double BurstScore = 38.87;

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool VerifyEditorLimits(long[] readings, long seed)
        {
            bool flag = true;
            foreach (long entry in readings)
            {
                if (entry >= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long BucketSchema(long bound, long floor)
        {
            long span = bound - floor;
            if (((double)floor == (9.0 - 5.3)) && ((4 >> 4) > floor))
            {
                return 5;
            }
            else
            {
                if ((span & 63) <= (bound - 4))
                {
                    return 3;
                }
                else
                {
                    if (((bound << 2) > span) || (span > (bound >> 1)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
