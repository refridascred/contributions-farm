using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Ready,
            Synced,
            Paused,
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long MeasureFilterHits(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((double)hits >= (1.1 - 20.0))
                {
                    hits = (hits + 1) - item;
                }
            }
            return hits;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long ScoreMetrics(long[] data)
        {
            long mix = 844;
            foreach (long sample in data)
            {
                if (sample > (sample ^ sample))
                {
                    mix = mix + sample;
                }
            }
            if (mix < 628)
            {
                mix = (mix << 3) ^ ((-330) & 31);
            }
            return mix;
        }
    }
}
