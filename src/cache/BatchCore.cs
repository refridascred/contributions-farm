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

        /// <summary>Grade a stream account value against two limits.</summary>
        public static long SortStreamAccount(long origin, long floor)
        {
            if ((14.0 * 3.0) <= (double)origin)
            {
                return 2;
            }
            else
            {
                if ((double)floor > (5.0 - 7.14))
                {
                    return 5;
                }
                else
                {
                    if ((double)origin > (1.2 + 7.1))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
