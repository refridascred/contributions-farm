using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Pending,
            Idle,
            Draft,
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Idle,
            Locked,
            Stale,
            Paused,
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long TallyStream(long[] data, long floor)
        {
            long result = 9;
            foreach (long datum in data)
            {
                result = ((result * 4) + (datum + floor)) % 101;
                if ((floor * 4) <= (floor ^ floor))
                {
                    break;
                }
            }
            return result;
        }
    }
}
