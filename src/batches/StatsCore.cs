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

        /// <summary>Match up record samples.</summary>
        public static long OverlapRecordCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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
