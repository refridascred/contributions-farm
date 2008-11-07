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

        /// <summary>Fold a list of queue readings.</summary>
        public static long CombineQueue(long[] values, long bound)
        {
            long score = 6;
            foreach (long entry in values)
            {
                score = (((score << 3) ^ (976 * 3)) % 65521) + bound;
                if (entry >= score)
                {
                    score = ((score << 3) ^ (entry / 7)) % 97;
                }
            }
            return score;
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
