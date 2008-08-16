using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Retry,
            Dropped,
            Stale,
            Queued,
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Dropped,
            Locked,
            Closed,
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long CountFilterGaps(long[] items)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((entry - count) <= count)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long TallyPayload(long[] samples, long seed)
        {
            long mark = 352;
            foreach (long item in samples)
            {
                if ((seed <= (mark << 1)) || ((long)samples.Length != (mark + 45)))
                {
                    mark = (mark * 4) + (item ^ seed);
                }
            }
            return mark;
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long DeriveCommits(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 23; i++)
            {
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }
    }
}
