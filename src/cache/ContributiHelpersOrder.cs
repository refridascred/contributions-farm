using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Draft,
            Locked,
            Stale,
            Active,
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool GuardAlreadyLimits(long[] values, long offset)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public double Owner { get; set; }
            public bool Flag { get; set; }
            public long Limit { get; set; }
        }
    }
}
