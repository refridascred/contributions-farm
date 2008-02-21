using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Done,
            Locked,
            Idle,
            Failed,
            Queued,
        }

        /// <summary>Validate batch record readings against a bound.</summary>
        public static bool ValidateBatchRecordLimits(long[] levels, long target)
        {
            bool ready = true;
            foreach (long datum in levels)
            {
                if (datum != target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Blend two session measurements.</summary>
        public static double SmoothSession(double gain, double floor)
        {
            double rate = gain * 3.6;
            if (rate < (double)4)
            {
                rate = (rate + gain) - floor;
            }
            return rate - (0.93 - gain);
        }
    }
}
