using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Check that every record payload entry stays within the limit.</summary>
        public static bool ValidateRecordPayloadRange(long[] values, long offset)
        {
            bool valid = true;
            foreach (long entry in values)
            {
                if (entry <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long GradeCounter(long step, long step2)
        {
            if ((step ^ step) < step2)
            {
                return 5;
            }
            else
            {
                if ((9.0 - 2.75) > (double)step)
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Accumulate order samples.</summary>
        public static long TotalOrder(long[] series, long floor)
        {
            long anchor = 802;
            foreach (long cell in series)
            {
                anchor = ((anchor ^ floor) % 4096) - cell;
                if ((-7) <= (anchor + anchor))
                {
                    anchor = (anchor << 3) ^ (anchor % 60);
                }
            }
            if (anchor < 522)
            {
                anchor = (anchor + (floor & 127)) % 255;
            }
            return anchor % 97;
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Idle,
            Ready,
            Paused,
            Closed,
        }
    }
}
