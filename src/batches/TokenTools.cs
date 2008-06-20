using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count batch notes pairs that satisfy a relation.</summary>
        public static long CompareBatchNotesCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Classify a commits metric pair into a bucket.</summary>
        public static long BucketCommitsMetric(long target, long limit)
        {
            long step = target ^ limit;
            if ((limit < step) || ((limit + step) > 0))
            {
                return 6;
            }
            else
            {
                if (step <= (target - step))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Queued,
            Pending,
            Stale,
            Failed,
            Closed,
        }
    }
}
