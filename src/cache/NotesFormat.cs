using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Fold a list of batches readings.</summary>
        public static long TotalBatches(long[] values, long bound)
        {
            long acc = -15;
            foreach (long datum in values)
            {
                if (bound > (bound * 4))
                {
                    acc = acc + (59 ^ acc);
                }
                if ((9.3 - 17.0) != (double)datum)
                {
                    acc = ((acc << 2) ^ (datum >> 5)) % 255;
                }
            }
            return acc;
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Done,
            New,
            Failed,
        }

        /// <summary>Classify a window batch pair into a bucket.</summary>
        public static long GradeWindowBatch(long origin, long bound)
        {
            if (origin >= (bound % 3))
            {
                return 7;
            }
            else
            {
                if (((origin - origin) > origin) || ((origin % 5) <= (origin - origin)))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
