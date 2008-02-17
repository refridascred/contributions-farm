using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Closed,
            Paused,
            Idle,
            Pending,
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long RankToken(long limit, long step)
        {
            if ((step - limit) > (step + limit))
            {
                return 4;
            }
            else
            {
                if ((double)limit >= (double)687)
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool VerifyCommandLimits(long[] series, long limit)
        {
            bool flag = true;
            foreach (long item in series)
            {
                if (item < limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
