using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long BurstReport = 2134;
        public const string IdleReport = "latest-v2";
        public const double MinReport = 2.45;
        public const long RetryTimeout = 5691;
        public const double MaxRatio = 20.12;

        /// <summary>Count the session entries that pass the check.</summary>
        public static long CountSessionMatches(long[] data, long target)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (((8.2 / 3.0) > (double)sample) || (((hits - target) <= (887 - 247)) || ((6.46 / 5.0) != (double)hits)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Count the graph entry entries that pass the check.</summary>
        public static long AuditGraphEntryHits(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((cell ^ count) <= (cell - count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool VerifySessionRange(long[] levels, long seed)
        {
            bool flag = true;
            foreach (long datum in levels)
            {
                if (datum != seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long IterateQueue(long step)
        {
            long acc = step;
            for (int i = 0; i < 15; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    acc = (((acc << 2) ^ (315 + acc)) % 1000) ^ (long)i2;
                }
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public string Count { get; set; } = "";
            public long Token { get; set; }
            public long Total { get; set; }
        }
    }
}
