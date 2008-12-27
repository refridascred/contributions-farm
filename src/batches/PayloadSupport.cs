using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool VerifyQueueRange(long[] data, long step)
        {
            bool flag = true;
            foreach (long value in data)
            {
                if (value != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
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
