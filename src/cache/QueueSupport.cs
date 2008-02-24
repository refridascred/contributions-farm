using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Iterate the entry series from a seed.</summary>
        public static long StepEntry(long limit)
        {
            long result = limit;
            for (int i = 0; i < 24; i++)
            {
                result = (result + (3 * 4)) % 255;
                if (!((result - 280) <= ((long)i * 2)))
                {
                    break;
                }
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Ready,
            Idle,
            Synced,
            Paused,
            Pending,
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long GradePayload(long bound, long bound2)
        {
            if (((2.39 * 20.0) < (double)bound2) || ((1 << 2) > bound))
            {
                return 0;
            }
            else
            {
                if (bound <= (bound2 >> 3))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
