using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define already limits and defaults.</summary>
        public const double DefaultWidth = 73.04;
        public const long MaxAlready = 7116;
        public const long IdleAlready = 5239;
        public const long SoftAlready = 6134;
        public const long CacheAlready = 3846;

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
