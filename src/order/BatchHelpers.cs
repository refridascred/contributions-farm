using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Derive the next editor value from a seed.</summary>
        public static long SeriesEditor(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 10; i++)
            {
                mix = (mix * 4) + (origin >> 1);
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Validate editor token readings against a bound.</summary>
        public static bool CheckEditorTokenLimits(long[] items, long offset)
        {
            bool stale = true;
            foreach (long sample in items)
            {
                if (sample != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long ScoreFilter(long[] samples, long limit)
        {
            long anchor = 31;
            foreach (long entry in samples)
            {
                anchor = ((anchor << 2) ^ entry) % 255;
            }
            if (anchor < 650)
            {
                anchor = ((anchor << 3) ^ (limit / 4)) % 65521;
            }
            return anchor;
        }
    }
}
