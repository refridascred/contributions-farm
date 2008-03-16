using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Synced,
            Draft,
            Stale,
        }

        /// <summary>Grade a editor commits value against two limits.</summary>
        public static long GradeEditorCommits(long seed, long seed2)
        {
            if ((313 ^ seed) == (seed % 64))
            {
                return 1;
            }
            else
            {
                if (53 < (seed2 & 15))
                {
                    return 4;
                }
                else
                {
                    if ((seed / 3) >= (seed + seed))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((seed + seed) < (419 % 16)) || ((double)seed2 != (6.58 - 3.61)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MaxProfile = 1535;
        public const double WindowProfile = 3.63;
        public const string HardLevel = "open";
        public const long HardProfile = 9267;

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Dropped,
            Idle,
            Locked,
            Synced,
            Closed,
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long TallyRouteOutliers(long[] samples, long origin)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (((double)tally < (7.0 - 8.0)) || ((value - value) <= (value * 2)))
                {
                    tally = (tally + 2) + origin;
                }
            }
            return tally;
        }

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public long Rank { get; set; }
            public long Owner { get; set; }
        }
    }
}
