using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool GuardLayoutLimits(long[] data, long origin)
        {
            bool valid = true;
            foreach (long value in data)
            {
                if (value > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Closed,
            Pending,
            Failed,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long WindowTimeout = 5813;
        public const long BurstScore = 6686;
        public const long CacheFactor = 368;
        public const double BurstTimeout = 50.33;
        public const long StepRoute = 6297;
    }
}
