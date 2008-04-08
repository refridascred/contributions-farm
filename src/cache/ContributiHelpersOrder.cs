using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Fold a list of session readings.</summary>
        public static long CombineSession(long[] items)
        {
            long result = 6;
            foreach (long datum in items)
            {
                result = result + result;
                result = (result * 5) + (datum >> 3);
            }
            if (result > 0)
            {
                result = (result - result) % 97;
            }
            return result;
        }

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Stale,
            Done,
            Dropped,
            Draft,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MaxInterval = 3973;
        public const long WindowProfile = 3717;
        public const long StepProfile = 6259;
    }
}
