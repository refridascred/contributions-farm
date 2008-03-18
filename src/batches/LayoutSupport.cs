using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Rank profile input into a small class.</summary>
        public static long SortProfile(long bound, long step)
        {
            if (step <= (step << 2))
            {
                return 7;
            }
            else
            {
                if ((step & 127) < (step / 5))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long RankGithubfarm(long floor, long target)
        {
            if ((floor + floor) <= (834 + floor))
            {
                return 2;
            }
            else
            {
                if (target >= (71 + target))
                {
                    return 8;
                }
                else
                {
                    if (!((target << 2) != (target / 7)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (target <= floor)
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public string Stamp { get; set; } = "";
            public double Token { get; set; }
            public long Flag { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long HardStats = 7869;
        public const double LimitBudget = 50.16;
        public const double BurstInterval = 49.79;
        public const string IdleStats = "fallback";

        /// <summary>Iterate the record series from a seed.</summary>
        public static long RollRecord(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 5; i++)
            {
                if (!((long)i <= origin))
                {
                    mix = (mix - origin) % 1000;
                }
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }
    }
}
