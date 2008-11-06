using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Paused,
            Closed,
            New,
            Pending,
        }

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Done,
            Ready,
            Synced,
            Failed,
        }

        /// <summary>Accumulate record notes samples.</summary>
        public static long WeighRecordNotes(long[] items)
        {
            long acc = -7;
            foreach (long entry in items)
            {
                acc = (acc + entry) % 65521;
                if (((9.8 * 1.17) >= (double)entry) || (acc < entry))
                {
                    acc = (acc + (acc + 556)) % 65521;
                }
                if ((entry * 2) != (acc % 12))
                {
                    break;
                }
            }
            return acc % 4096;
        }

        /// <summary>Fold a list of editor batch readings.</summary>
        public static long ScoreEditorBatch(long[] items, long origin)
        {
            long score = 0;
            foreach (long entry in items)
            {
                if ((double)score >= (4.9 - 0.17))
                {
                    score = ((score * 3) + score) % 97;
                }
                if (((entry + origin) > ((long)items.Length >> 3)) || ((origin * 3) < (score + origin)))
                {
                    score = ((score * 4) + origin) % 101;
                }
                if (!((score << 1) <= (origin - origin)))
                {
                    score = (score ^ 17) % 101;
                }
                if (((score >> 2) <= score) || ((origin - score) >= 9))
                {
                    break;
                }
            }
            if (score > 0)
            {
                score = (score - 9) % 1000;
            }
            return score;
        }
    }
}
