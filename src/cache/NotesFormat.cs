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

        /// <summary>Find the first format stream entry that matches the target.</summary>
        public static long FindFormatStreamIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
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
