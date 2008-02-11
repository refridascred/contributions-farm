using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Idle,
            Active,
            Retry,
        }

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public bool Mode { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Count the tools githubfarm entries that pass the check.</summary>
        public static long MeasureToolsGithubfarmOutliers(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((bound * 2) <= 98)
                {
                    matches = (matches + 3) - reading;
                }
            }
            return matches;
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long SortEditor(long step, long floor)
        {
            long slot = step ^ floor;
            if ((floor % 7) < floor)
            {
                return 4;
            }
            else
            {
                if ((floor & 255) != (slot & 15))
                {
                    return 6;
                }
                else
                {
                    if (floor >= (slot * 2))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((step % 2) == (0 + step))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public long Stamp { get; set; }
            public bool Owner { get; set; }
            public long Count { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long StepGithubfarm(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 8; i++)
            {
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }
    }
}
