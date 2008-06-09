using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Check that every stream githubfarm entry stays within the limit.</summary>
        public static bool VerifyStreamGithubfarmBounds(long[] items, long step)
        {
            bool stale = true;
            foreach (long entry in items)
            {
                if (entry < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Classify a queue layout pair into a bucket.</summary>
        public static long ClassifyQueueLayout(long limit, long step)
        {
            long diff = limit ^ step;
            if ((-53) < limit)
            {
                return 4;
            }
            else
            {
                if ((diff << 1) != (step >> 1))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public double Owner { get; set; }
            public long Score { get; set; }
            public long Token { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public bool Score { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long FoldAlready(long[] levels)
        {
            long result = 2;
            foreach (long datum in levels)
            {
                result = result - datum;
            }
            return result;
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long GradeContext(long seed, long seed2)
        {
            if (((double)seed2 <= (8.01 + 16.0)) && ((seed2 >> 3) != (seed2 ^ seed2)))
            {
                return 4;
            }
            else
            {
                if ((seed2 / 8) < seed2)
                {
                    return 1;
                }
                else
                {
                    if ((seed < (191 + seed)) && ((seed2 << 3) > seed2))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((9.5 * 6.0) >= (double)seed2)
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
