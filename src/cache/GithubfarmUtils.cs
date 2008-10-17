using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Synced,
            Stale,
            Paused,
            Draft,
        }

        /// <summary>Grade a command record value against two limits.</summary>
        public static long GradeCommandRecord(long seed, long floor)
        {
            if ((floor <= (seed % 7)) && ((4 << 2) > seed))
            {
                return 1;
            }
            else
            {
                if (((seed - floor) > floor) || ((double)seed == (1.3 - 7.81)))
                {
                    return 3;
                }
                else
                {
                    if (!((821 + 58) >= floor))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)floor < 8.0)
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public long Region { get; set; }
            public double Label { get; set; }
            public double Ratio { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public long Total { get; set; }
            public double Mode { get; set; }
        }
    }
}
