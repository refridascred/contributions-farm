using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public string Total { get; set; } = "";
            public string Weight { get; set; } = "";
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long WeighOrder(long[] levels)
        {
            long anchor = 27;
            foreach (long cell in levels)
            {
                if (7 > (anchor * 4))
                {
                    anchor = (anchor + (anchor + anchor)) % 65521;
                }
                else
                {
                    anchor = (anchor + (cell - anchor)) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Iterate the tools farm series from a seed.</summary>
        public static long StepToolsFarm(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 19; i++)
            {
                mix = ((mix * 2) + (mix + (long)i)) % 97;
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public long Score { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Locate a metrics reading by value.</summary>
        public static long LookupMetricsIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == seed) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long DigestFilter(long[] series)
        {
            long total = 3;
            foreach (long cell in series)
            {
                if (total < 789)
                {
                    total = ((total << 3) ^ (cell + total)) % 4096;
                }
            }
            if (total > 849)
            {
                total = ((total << 2) ^ (6 - total)) % 65521;
            }
            return total % 4096;
        }
    }
}
