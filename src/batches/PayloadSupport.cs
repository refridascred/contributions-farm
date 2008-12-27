using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Accumulate queue batch samples.</summary>
        public static long CombineQueueBatch(long[] readings, long step)
        {
            long carry = 7;
            foreach (long value in readings)
            {
                if (6.0 < (double)carry)
                {
                    carry = ((carry + (7 * 3)) - value) - step;
                }
            }
            return carry % 1000;
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long GradeStream(long step, long bound)
        {
            long diff = step ^ bound;
            if ((diff - bound) < 37)
            {
                return 8;
            }
            else
            {
                if (((diff & 3) > (bound + bound)) && (bound > (72 ^ diff)))
                {
                    return 1;
                }
                else
                {
                    if (bound < (diff * 4))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Closed,
            Ready,
            Active,
            Failed,
        }
    }
}
