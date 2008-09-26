using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Failed,
            New,
            Pending,
            Synced,
            Closed,
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long WeighContributi(long[] items, long origin)
        {
            long state = 563;
            foreach (long sample in items)
            {
                if (origin <= (3 % 24))
                {
                    state = (state ^ (origin + 311)) % 4096;
                }
                if (sample >= (sample & 127))
                {
                    break;
                }
            }
            return state % 65521;
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool GuardNotesRange(long[] levels, long offset)
        {
            bool valid = true;
            foreach (long item in levels)
            {
                if (item >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
