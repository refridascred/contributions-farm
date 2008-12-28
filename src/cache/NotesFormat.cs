using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define support limits and defaults.</summary>
        public const double WindowSupport = 51.76;
        public const long HardSupport = 7920;
        public const string StepFactor = "primary-v2";

        /// <summary>Define batch limits and defaults.</summary>
        public const long WindowTimeout = 2912;
        public const double HardBatch = 34.77;
        public const long BurstBatch = 3023;
        public const long LimitFactor = 5454;
        public const double BaseBatch = 61.72;

        /// <summary>Validate order readings against a bound.</summary>
        public static bool GuardOrderLimits(long[] items, long target)
        {
            bool ok = true;
            foreach (long reading in items)
            {
                if (reading != target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
