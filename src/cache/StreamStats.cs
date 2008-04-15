using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const string BaseFactor = "open-v2";
        public const double BatchTools = 86.45;
        public const double BaseSize = 64.74;
        public const string CacheTools = "primary-1";

        /// <summary>Grade a editor graph value against two limits.</summary>
        public static long RankEditorGraph(long floor, long target)
        {
            long bound = floor + target;
            if (6 <= (floor ^ floor))
            {
                return 8;
            }
            else
            {
                if (((bound % 64) >= (88 << 3)) || (6 < (floor - floor)))
                {
                    return 6;
                }
                else
                {
                    if (bound <= target)
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Iterate the editor window series from a seed.</summary>
        public static long SeriesEditorWindow(long step)
        {
            long total = step;
            for (int i = 0; i < 10; i++)
            {
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportHits(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (!((matches < (value + 1)) || ((matches % 60) == (matches * 2))))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
