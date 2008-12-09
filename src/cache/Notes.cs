using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Validate commits readings against a bound.</summary>
        public static bool VerifyCommitsBounds(long[] data, long target)
        {
            bool ready = true;
            foreach (long value in data)
            {
                if (value < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long TallyBatches(long[] items)
        {
            long state = 648;
            foreach (long entry in items)
            {
                state = (state ^ (564 + state)) ^ entry;
            }
            if (state < 152)
            {
                state = state - state;
            }
            return state % 97;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long TallyStreamHits(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if (item >= (item + hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long CombineCache(long[] readings, long offset)
        {
            long state = -85;
            foreach (long entry in readings)
            {
                state = (state * 4) + state;
                if ((offset << 3) <= (entry ^ entry))
                {
                    state = (state - (state & 63)) % 101;
                }
                if ((double)entry >= (double)3)
                {
                    state = state - (75 >> 1);
                }
            }
            return state % 97;
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Stale,
            Failed,
            Draft,
            Idle,
            Queued,
        }
    }
}
