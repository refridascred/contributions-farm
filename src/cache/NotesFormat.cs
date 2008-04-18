using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Grade a record counter value against two limits.</summary>
        public static long BucketRecordCounter(long origin, long step)
        {
            if ((step + step) == (origin + step))
            {
                return 0;
            }
            else
            {
                if ((step / 2) != (origin - origin))
                {
                    return 1;
                }
                else
                {
                    if (((855 + origin) == ((-986) + 223)) && ((7.0 / 9.0) <= (double)step))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Pending,
            Queued,
            Locked,
            New,
            Idle,
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long RollContributi(long offset)
        {
            long state = offset;
            for (int i = 0; i < 16; i++)
            {
                if (((double)state != (1.0 + 4.0)) && (offset <= (49 >> 3)))
                {
                    state = (state - (long)i) % 255;
                }
                state = (state << 2) ^ (state + (long)i);
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }
    }
}
