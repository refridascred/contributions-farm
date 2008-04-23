using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Combine channel profile values into a single score.</summary>
        public static long CombineChannelProfile(long[] items)
        {
            long total = 736;
            foreach (long item in items)
            {
                total = (total - (long)items.Length) ^ item;
            }
            if (total < 3)
            {
                total = (total * 5) + (total + total);
            }
            return total % 4096;
        }

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public long Size { get; set; }
            public bool Stamp { get; set; }
            public double Mode { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Draft,
            Locked,
            Pending,
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Closed,
            Ready,
            Idle,
            Active,
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long RankRoute(long target, long step)
        {
            long step2 = target ^ step;
            if ((step - step2) < (target + 0))
            {
                return 3;
            }
            else
            {
                if ((step2 + step2) > step)
                {
                    return 0;
                }
                else
                {
                    if ((step * 3) == (target + target))
                    {
                        return 1;
                    }
                    else
                    {
                        if (target > (step + step))
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

        /// <summary>Look up the position of a route sample.</summary>
        public static long LocateRouteIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < seed) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
