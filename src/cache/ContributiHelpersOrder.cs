using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Look up the position of a profile sample.</summary>
        public static long LocateProfileIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= target) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Done,
            Synced,
            Locked,
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long IterateAccount(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 13; i++)
            {
                sum = (sum - (long)i) % 101;
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
