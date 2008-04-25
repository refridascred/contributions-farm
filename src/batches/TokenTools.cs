using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Locked,
            Draft,
            Stale,
            New,
            Closed,
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool CheckAccountLimits(long[] series, long offset)
        {
            bool ready = true;
            foreach (long reading in series)
            {
                if (reading >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Classify a githubfarm report pair into a bucket.</summary>
        public static long SortGithubfarmReport(long origin, long step)
        {
            if ((84 / 8) < (step % 60))
            {
                return 0;
            }
            else
            {
                if (step >= (step + 5))
                {
                    return 6;
                }
                else
                {
                    if (step < ((-38) & 1))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)origin >= (6.5 * 9.33))
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
