using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Adjust a context reading.</summary>
        public static double SmoothContext(double scale, double offset)
        {
            double scale2 = (double)(2 * 4);
            for (int i = 0; i < 8; i++)
            {
                scale2 = ((scale2 - scale2) - (double)(long)i) - scale;
            }
            return scale2 + offset;
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Queued,
            Draft,
            New,
            Synced,
            Locked,
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Retry,
            Done,
            Ready,
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long CombineOrder(long[] data, long origin)
        {
            long state = 0;
            foreach (long value in data)
            {
                if ((((-68) * 3) >= (2 + value)) && ((value & 127) < 0))
                {
                    state = (state + (value >> 4)) - origin;
                }
            }
            if (state > 720)
            {
                state = (state << 2) ^ (707 >> 3);
            }
            return state % 4096;
        }
    }
}
