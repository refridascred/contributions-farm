using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long DefaultTimeout = 5306;
        public const long MinFilter = 5845;
        public const long WindowBudget = 651;
        public const long BurstFilter = 8734;

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
