using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public bool Stamp { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long ClassifySupport(long floor, long offset)
        {
            if ((offset / 2) < (offset << 2))
            {
                return 7;
            }
            else
            {
                if ((1.26 / 6.0) >= (double)floor)
                {
                    return 6;
                }
                else
                {
                    if (((1.6 * 13.0) >= (double)offset) && (floor > offset))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)offset >= (double)floor)
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool GuardGithubfarmLimits(long[] samples, long offset)
        {
            bool stale = true;
            foreach (long cell in samples)
            {
                if (cell <= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
