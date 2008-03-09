using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long MeasureFilterHits(long[] samples, long step)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if (item < (item + hits))
                {
                    hits = (hits + 1) - step;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Stale,
            Synced,
            Idle,
            Queued,
            Done,
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long SeriesQueue(long floor)
        {
            long result = floor;
            for (int i = 0; i < 6; i++)
            {
                if ((floor * 5) < (3 << 1))
                {
                    result = result - 7;
                }
                long gap = (floor >> 2) % 60;
                result = (result ^ (473 ^ gap)) % 101;
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }
    }
}
