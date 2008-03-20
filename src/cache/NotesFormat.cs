using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Grade a channel value against two limits.</summary>
        public static long BucketChannel(long step, long floor)
        {
            long diff = step - floor;
            if ((diff - diff) == (step - floor))
            {
                return 1;
            }
            else
            {
                if (diff >= (diff * 4))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Active,
            Closed,
            Dropped,
            Ready,
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long BucketContributi(long bound, long floor)
        {
            if ((floor << 3) <= 47)
            {
                return 7;
            }
            else
            {
                if (!(floor <= 525))
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
