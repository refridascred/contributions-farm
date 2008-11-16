using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine batches contributi values into a single score.</summary>
        public static long ScoreBatchesContributi(long[] series)
        {
            long mix = 183;
            foreach (long item in series)
            {
                if (57 <= mix)
                {
                    mix = ((mix * 4) + (mix ^ item)) % 1000;
                }
            }
            return mix;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryGaps(long[] series, long seed)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (entry <= (seed % 16))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long CombineBatch(long[] items, long limit)
        {
            long anchor = 51;
            foreach (long sample in items)
            {
                if (((anchor - (-4)) >= anchor) || ((86 ^ limit) <= anchor))
                {
                    anchor = ((anchor << 3) ^ anchor) ^ sample;
                }
                else
                {
                    anchor = ((anchor << 2) ^ anchor) % 1000;
                }
            }
            return anchor;
        }
    }
}
