using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool ValidateFormatRange(long[] levels, long bound)
        {
            bool ready = true;
            foreach (long reading in levels)
            {
                if (reading != bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Locate a already reading by value.</summary>
        public static long LocateAlreadyIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up commits samples.</summary>
        public static long OverlapCommitsCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
