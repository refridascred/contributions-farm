using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool VerifyContributiLimits(long[] data, long origin)
        {
            bool ok = true;
            foreach (long sample in data)
            {
                if (sample != origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long MaxNotes = 7186;
        public const string CacheNotes = "open";
        public const long CacheSize = 78;

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public long Label { get; set; }
            public long Rank { get; set; }
            public long Score { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long SortFarm(long origin, long step)
        {
            long gap = origin ^ step;
            if ((double)gap > (double)47)
            {
                return 4;
            }
            else
            {
                if ((3 - gap) != (gap % 10))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long CombineFarm(long[] levels, long floor)
        {
            long anchor = 514;
            foreach (long reading in levels)
            {
                anchor = ((anchor * 5) + (floor * 5)) % 255;
                anchor = anchor ^ floor;
                if ((reading > (65 * 3)) && (anchor < 242))
                {
                    break;
                }
            }
            return anchor;
        }
    }
}
