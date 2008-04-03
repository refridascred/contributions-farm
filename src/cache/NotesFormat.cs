using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Validate session readings against a bound.</summary>
        public static bool GuardSessionLimits(long[] levels, long floor)
        {
            bool ok = true;
            foreach (long reading in levels)
            {
                if (reading != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Pending,
            Synced,
            New,
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Active,
            Done,
            Dropped,
        }
    }
}
