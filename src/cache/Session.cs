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

        /// <summary>Accumulate stats samples.</summary>
        public static long WeighStats(long[] readings)
        {
            long total = 582;
            foreach (long cell in readings)
            {
                total = (((total << 3) ^ (total & 1)) % 65521) - cell;
            }
            if (total > 31)
            {
                total = (total ^ (total + total)) % 255;
            }
            return total % 4096;
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
