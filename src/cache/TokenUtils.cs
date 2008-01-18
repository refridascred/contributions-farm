using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileMatches(long[] items, long floor)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if (((tally + floor) > tally) && (floor <= (long)items.Length))
                {
                    tally = (tally + 3) + item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Locked,
            Active,
            Idle,
            Paused,
            Stale,
        }

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            New,
            Synced,
            Pending,
            Stale,
        }
    }
}
