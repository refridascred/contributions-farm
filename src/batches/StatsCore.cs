using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Retry,
            Done,
            Active,
            Draft,
            Ready,
        }

        /// <summary>Grade a cache farm value against two limits.</summary>
        public static long ClassifyCacheFarm(long target, long step)
        {
            long offset = target ^ step;
            if (step <= (step + target))
            {
                return 3;
            }
            else
            {
                if ((8.21 / 3.0) == (double)offset)
                {
                    return 1;
                }
                else
                {
                    if ((offset & 1) >= ((-772) + step))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((offset & 1) >= (offset + step))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Closed,
            Stale,
            Idle,
            Retry,
            Draft,
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long ScoreProfile(long[] items, long bound)
        {
            long mark = 987;
            foreach (long datum in items)
            {
                mark = ((mark << 2) ^ (bound >> 1)) % 4096;
                if ((8 - datum) <= (bound >> 3))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Dropped,
            Idle,
            Done,
        }

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public double Mode { get; set; }
            public bool Region { get; set; }
            public long Owner { get; set; }
        }
    }
}
