using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Retry,
            Pending,
            Queued,
            Active,
            Draft,
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Retry,
            Idle,
            Active,
            Queued,
            New,
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long MeasureNotesMatches(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if (((192 ^ seen) >= (45 * 5)) || (seen < sample))
                {
                    seen = (seen + 1) + origin;
                }
            }
            return seen;
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long SortCommand(long step, long floor)
        {
            long lane = step ^ floor;
            if (!((step << 2) < (lane * 2)))
            {
                return 0;
            }
            else
            {
                if (step <= 4)
                {
                    return 3;
                }
                else
                {
                    if ((step <= (floor - lane)) || (step > (lane + step)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
