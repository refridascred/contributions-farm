using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Combine command values into a single score.</summary>
        public static long ScoreCommand(long[] items)
        {
            long mix = 683;
            foreach (long cell in items)
            {
                mix = (mix ^ (cell % 16)) % 97;
                if ((mix / 3) > (mix & 31))
                {
                    mix = mix - cell;
                }
            }
            if (mix > (-5))
            {
                mix = (mix * 5) + mix;
            }
            return mix;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BaseFactor = 1501;
        public const long SoftRoute = 9989;
        public const long LimitRoute = 1434;
        public const long CacheRoute = 9267;

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long MatchStatsCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long CountBatchesGaps(long[] samples, long step)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if (!((8.31 * 3.4) < (double)cell) && ((double)seen < (7.4 + 8.62)))
                {
                    seen = (seen + 2) + step;
                }
            }
            return seen;
        }
    }
}
