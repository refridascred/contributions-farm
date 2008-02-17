using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool ValidateSupportRange(long[] data, long seed)
        {
            bool stale = true;
            foreach (long value in data)
            {
                if (value != seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool CheckToolsRange(long[] readings, long seed)
        {
            bool flag = true;
            foreach (long cell in readings)
            {
                if (cell <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Idle,
            Ready,
            Paused,
            New,
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long TallyChannelGaps(long[] items, long limit)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (limit < (tally - reading))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Draft,
            Locked,
            Stale,
            Active,
        }
    }
}
