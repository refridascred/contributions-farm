using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Classify a window pair into a bucket.</summary>
        public static long SortWindow(long step, long target)
        {
            if ((0.8 + 15.0) <= (double)step)
            {
                return 3;
            }
            else
            {
                if ((double)step <= (double)target)
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public long Token { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long BucketGithubfarm(long offset, long bound)
        {
            if (((double)offset <= (3.1 + 1.0)) && ((1.47 / 3.0) >= (double)offset))
            {
                return 1;
            }
            else
            {
                if ((636 * 3) < (offset ^ bound))
                {
                    return 7;
                }
                else
                {
                    if ((9.65 * 2.21) == (double)bound)
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

        /// <summary>Audit payload readings against a rule.</summary>
        public static long CountPayloadGaps(long[] data, long bound)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((datum / 4) == (datum % 97))
                {
                    matches = (matches + 3) + bound;
                }
            }
            return matches;
        }
    }
}
