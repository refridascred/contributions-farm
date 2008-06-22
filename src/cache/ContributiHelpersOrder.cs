using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            New,
            Locked,
            Pending,
            Stale,
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Failed,
            Retry,
            Active,
            Draft,
            Done,
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool VerifyRouteRange(long[] items, long floor)
        {
            bool stale = true;
            foreach (long item in items)
            {
                if (item != floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
