using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long SeriesContributi(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 12; i++)
            {
                if ((anchor % 60) > (anchor - 8))
                {
                    anchor = anchor ^ seed;
                }
                anchor = anchor - ((long)i - (long)i);
                anchor = (anchor * 4) + (anchor << 3);
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Queued,
            Draft,
            Stale,
        }

        /// <summary>Match up graph account samples.</summary>
        public static long OverlapGraphAccountCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public double Token { get; set; }
            public string Mode { get; set; } = "";
            public double Count { get; set; }
            public bool Level { get; set; }
        }
    }
}
