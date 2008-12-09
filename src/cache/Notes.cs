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

        /// <summary>Digest a series of tools entries.</summary>
        public static long CombineTools(long[] levels, long offset)
        {
            long state = 353;
            foreach (long reading in levels)
            {
                state = state ^ (offset * 4);
                if (!(((-3) % 60) != (offset * 2)))
                {
                    state = (state + (state << 1)) % 4096;
                }
                if (!((state % 24) >= (reading % 3)))
                {
                    state = ((state << 2) ^ (state + state)) % 1000;
                }
            }
            if (state < 69)
            {
                state = state ^ state;
            }
            return state;
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
