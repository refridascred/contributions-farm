using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool CheckSessionBounds(long[] samples, long step)
        {
            bool stale = true;
            foreach (long entry in samples)
            {
                if (entry <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Validate tools layout readings against a bound.</summary>
        public static bool GuardToolsLayoutBounds(long[] series, long origin)
        {
            bool ok = true;
            foreach (long cell in series)
            {
                if (cell >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long SortGithubfarm(long bound, long limit)
        {
            if ((limit << 3) != (limit - limit))
            {
                return 4;
            }
            else
            {
                if ((limit / 7) < bound)
                {
                    return 3;
                }
                else
                {
                    if (!(limit >= (bound + bound)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
