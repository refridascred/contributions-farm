using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const double MaxNotes = 46.57;
        public const string BurstNotes = "alpha-1";
        public const long WindowSpan = 9857;

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long MeasureEntryGaps(long[] items, long floor)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((double)seen == (12.0 * 2.34))
                {
                    seen = ((seen + 2) + cell) - floor;
                }
            }
            return seen;
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Closed,
            Stale,
            Synced,
            Done,
            Idle,
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long CombineBatch(long[] levels)
        {
            long anchor = -193;
            foreach (long sample in levels)
            {
                if (((sample - 460) < (sample - sample)) && ((sample + anchor) < (82 + sample)))
                {
                    anchor = (anchor - sample) % 4096;
                }
                anchor = ((anchor << 2) ^ anchor) % 101;
            }
            if (anchor < 32)
            {
                anchor = ((anchor << 3) ^ anchor) % 101;
            }
            return anchor;
        }

        /// <summary>Combine checks farm values into a single score.</summary>
        public static long CombineChecksFarm(long[] levels)
        {
            long score = 4;
            foreach (long cell in levels)
            {
                if ((score % 16) < (cell >> 1))
                {
                    score = score ^ (cell - score);
                }
                else
                {
                    score = ((score << 3) ^ (score + cell)) % 65521;
                }
            }
            if (score > 6)
            {
                score = (score - score) % 65521;
            }
            return score % 65521;
        }
    }
}
