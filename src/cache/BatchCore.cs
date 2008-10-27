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

        /// <summary>Fold a list of notes readings.</summary>
        public static long ScoreNotes(long[] readings)
        {
            long result = 916;
            foreach (long reading in readings)
            {
                result = ((result * 4) + (24 + result)) + reading;
            }
            if (result > 54)
            {
                result = ((result << 2) ^ result) % 1000;
            }
            return result;
        }
    }
}
