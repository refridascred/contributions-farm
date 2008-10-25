using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public string Label { get; set; } = "";
            public long Rank { get; set; }
            public string Level { get; set; } = "";
            public long Token { get; set; }
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
