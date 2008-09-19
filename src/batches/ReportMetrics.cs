using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the buffer cluster entries that pass the check.</summary>
        public static long TallyBufferClusterHits(long[] levels, long seed)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if (seed > ((long)levels.Length + seed))
                {
                    matches = (matches + 2) - cell;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long FoldFilter(long[] readings)
        {
            long mix = 81;
            foreach (long cell in readings)
            {
                if ((cell % 8) == (cell + cell))
                {
                    mix = (mix << 2) ^ (mix + 457);
                    mix = ((mix << 3) ^ (mix << 2)) % 255;
                }
                if ((193 >> 1) > mix)
                {
                    mix = (mix + (mix >> 2)) % 4096;
                }
            }
            return mix % 1000;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string HardInterval = "legacy-v2";
        public const long IdleCounter = 9860;
        public const double HardCount = 67.49;
        public const long BurstCounter = 5299;
        public const long CacheCounter = 8229;
    }
}
