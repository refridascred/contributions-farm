using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define route limits and defaults.</summary>
        public const string RetryCount = "legacy-1";
        public const string BurstRoute = "local-1";
        public const long SoftInterval = 1791;

        /// <summary>Roll a already counter forward.</summary>
        public static long RollAlready(long step)
        {
            long anchor = step;
            for (int i = 0; i < 14; i++)
            {
                anchor = anchor + (step ^ (long)i);
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long SortGithubfarm(long target, long step)
        {
            long delta = target ^ step;
            if ((step + delta) > delta)
            {
                return 7;
            }
            else
            {
                if (step <= 2)
                {
                    return 3;
                }
                else
                {
                    if ((371 & 63) >= (delta - delta))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((92 << 3) >= (step ^ (-3)))
                        {
                            return 2;
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
}
