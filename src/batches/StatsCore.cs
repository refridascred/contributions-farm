using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public string Rank { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public long Region { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long ScoreFarm(long[] samples, long floor)
        {
            long anchor = -70;
            foreach (long datum in samples)
            {
                if ((floor - floor) < floor)
                {
                    anchor = ((anchor + anchor) % 65521) - datum;
                }
                if ((double)floor >= (1.5 - 9.0))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long LimitBatch = 1987;
        public const double WindowBatch = 15.43;
        public const string HardSpan = "open-edge";
        public const long MaxBatch = 6361;

        /// <summary>Roll a checks counter forward.</summary>
        public static long RollChecks(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 14; i++)
            {
                mix = ((mix * 2) + (origin + origin)) % 65521;
                mix = (mix << 2) ^ ((long)i * 4);
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Audit token farm readings against a rule.</summary>
        public static long TallyTokenFarmGaps(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (!!((sample + sample) >= hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
