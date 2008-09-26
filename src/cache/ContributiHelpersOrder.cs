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

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool ValidateFarmLimits(long[] values, long step)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value >= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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
