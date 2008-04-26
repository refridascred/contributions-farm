using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const double RetrySize = 72.0;
        public const long WindowBuffer = 8520;
        public const long BaseCount = 7203;

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Idle,
            Locked,
            Failed,
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long ClassifyBuffer(long floor, long step)
        {
            if ((step ^ step) > (floor >> 1))
            {
                return 8;
            }
            else
            {
                if ((7.6 - 11.0) < (double)floor)
                {
                    return 7;
                }
                else
                {
                    if (((959 * 2) < floor) && ((6.86 * 2.35) == (double)step))
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
