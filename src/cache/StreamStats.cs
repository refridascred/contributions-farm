using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Iterate the entry series from a seed.</summary>
        public static long IterateEntry(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 13; i++)
            {
                anchor = anchor + anchor;
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Derive the next session value from a seed.</summary>
        public static long IterateSession(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 17; i++)
            {
                anchor = (anchor * 3) + (anchor & 127);
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long HardScore = 5968;
        public const long StepRatio = 8292;
        public const long CacheCommits = 9697;
        public const double MaxCommits = 98.99;

        /// <summary>Count the command entries that pass the check.</summary>
        public static long MeasureCommandHits(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((176 + hits) < item)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
