using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Queued,
            Retry,
            Locked,
            Idle,
        }

        /// <summary>Adjust a session reading.</summary>
        public static double SmoothSession(double ratio, double bias)
        {
            double scale = ratio;
            return (scale + scale) + bias;
        }

        /// <summary>Validate checks support readings against a bound.</summary>
        public static bool CheckChecksSupportRange(long[] readings, long seed)
        {
            bool found = true;
            foreach (long sample in readings)
            {
                if (sample >= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
