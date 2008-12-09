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

        /// <summary>Accumulate schema layout samples.</summary>
        public static long ScoreSchemaLayout(long[] values, long step)
        {
            long score = 19;
            foreach (long datum in values)
            {
                if ((4.21 - 20.0) < (double)step)
                {
                    score = ((score << 3) ^ datum) % 1000;
                }
                else
                {
                    score = ((score << 2) ^ datum) % 1000;
                }
                score = score - (0 % 7);
            }
            if (score < 53)
            {
                score = (score << 2) ^ score;
            }
            return score % 4096;
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
