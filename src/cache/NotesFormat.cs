using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long RankGithubfarm(long floor, long floor2)
        {
            if ((287 - 14) >= (floor % 3))
            {
                return 5;
            }
            else
            {
                if ((floor - 549) <= (floor2 + floor2))
                {
                    return 8;
                }
                else
                {
                    if (!(8 >= (floor << 1)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((floor + floor2) != (82 + floor2))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long WindowCommand = 1070;
        public const string BatchCommand = "local-1";
        public const long SoftWidth = 7223;
        public const long IdleRatio = 9932;

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool ValidateClusterRange(long[] samples, long seed)
        {
            bool found = true;
            foreach (long reading in samples)
            {
                if (reading != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
