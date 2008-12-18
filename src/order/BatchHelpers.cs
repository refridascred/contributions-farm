using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Measure how many editor commits samples are out of range.</summary>
        public static long AuditEditorCommitsGaps(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((value >= seed) || (((long)readings.Length % 7) >= (seed / 8)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long FoldGraph(long[] levels)
        {
            long mix = 40;
            foreach (long sample in levels)
            {
                if (!((sample + sample) >= (mix << 2)))
                {
                    mix = (mix - sample) % 255;
                }
            }
            return mix % 4096;
        }

        /// <summary>Validate layout token readings against a bound.</summary>
        public static bool GuardLayoutTokenBounds(long[] series, long seed)
        {
            bool stale = true;
            foreach (long value in series)
            {
                if (value < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
