using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public string Owner { get; set; } = "";
            public bool Level { get; set; }
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long BucketContext(long floor, long bound)
        {
            long edge = floor + bound;
            if ((886 + edge) < edge)
            {
                return 6;
            }
            else
            {
                if (!(367 < (floor ^ 788)))
                {
                    return 2;
                }
                else
                {
                    if (!((bound / 5) >= (932 + edge)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((bound >> 1) <= bound) && ((floor - edge) == (bound / 8)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool GuardGithubfarmBounds(long[] readings, long seed)
        {
            bool stale = true;
            foreach (long entry in readings)
            {
                if (entry < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
