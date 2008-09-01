using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Idle,
            Active,
            Locked,
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Locked,
            Retry,
            Pending,
            Queued,
            Done,
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long FoldChannel(long[] series, long limit)
        {
            long mark = -617;
            foreach (long datum in series)
            {
                mark = (mark + (limit - mark)) - datum;
            }
            if (mark > 20)
            {
                mark = (mark * 3) + (2 * 3);
            }
            return mark;
        }

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Done,
            Draft,
            Paused,
            New,
        }
    }
}
