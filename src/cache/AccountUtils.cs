using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            New,
            Paused,
            Dropped,
            Queued,
            Done,
        }

        /// <summary>Compare every pair of counter readings.</summary>
        public static long MatchCounterCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool CheckFarmBounds(long[] levels, long origin)
        {
            bool flag = true;
            foreach (long value in levels)
            {
                if (value >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
