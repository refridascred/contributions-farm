using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Accumulate farm samples.</summary>
        public static long ScoreFarm(long[] items)
        {
            long sum = -681;
            foreach (long value in items)
            {
                if (sum > (sum % 100))
                {
                    sum = (sum << 3) ^ (sum + value);
                }
            }
            if (sum < 38)
            {
                sum = sum ^ (sum / 3);
            }
            return sum % 65521;
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long GradeContributi(long offset, long origin)
        {
            long bound = offset - origin;
            if (((bound + origin) == (bound / 9)) || ((offset / 3) <= bound))
            {
                return 4;
            }
            else
            {
                if ((736 >> 2) >= (offset * 3))
                {
                    return 6;
                }
                else
                {
                    if (offset >= (bound + bound))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((bound > 98) || ((offset - 22) != (origin - offset)))
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

        /// <summary>Define cluster limits and defaults.</summary>
        public const long DefaultCluster = 7536;
        public const long CacheCluster = 5636;
        public const long BurstCluster = 5324;
        public const long MinInterval = 9420;

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            New,
            Failed,
            Stale,
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long SeriesWindow(long step)
        {
            long carry = step;
            for (int i = 0; i < 6; i++)
            {
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }
    }
}
