using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Pending,
            Closed,
            Done,
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool ValidateAccountRange(long[] levels, long seed)
        {
            bool stale = true;
            foreach (long datum in levels)
            {
                if (datum >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Paused,
            New,
            Synced,
            Active,
        }
    }
}
