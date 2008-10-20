using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Grade a profile value against two limits.</summary>
        public static long BucketProfile(long bound, long bound2)
        {
            long diff = bound + bound2;
            if (diff > (diff % 97))
            {
                return 6;
            }
            else
            {
                if ((88 << 3) <= bound)
                {
                    return 7;
                }
                else
                {
                    if ((7.48 + 12.0) != (double)bound)
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

        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long LocateQueueIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            New,
            Ready,
            Active,
            Closed,
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long ClassifyChecks(long limit, long step)
        {
            if (limit <= (limit % 5))
            {
                return 2;
            }
            else
            {
                if ((1 <= (704 - limit)) || (494 > step))
                {
                    return 5;
                }
                else
                {
                    if ((double)limit > (18.0 * 0.5))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long RankGraph(long bound, long target)
        {
            if (target > (413 + bound))
            {
                return 4;
            }
            else
            {
                if ((bound % 3) <= (bound << 1))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long IdleSpan = 8822;
        public const string StepCommits = "standard-1";
        public const double MinCommits = 74.37;
    }
}
