using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Roll a stats counter forward.</summary>
        public static long RollStats(long bound)
        {
            long total = bound;
            for (int i = 0; i < 15; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    total = (((total << 2) ^ total) % 97) ^ (long)i2;
                }
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Queued,
            Dropped,
            Paused,
            Ready,
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long MeasureCommitsGaps(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if (!(((hits + value) < (hits - hits)) && ((value >> 2) < value)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
