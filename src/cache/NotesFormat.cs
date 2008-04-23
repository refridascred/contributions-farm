using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Retry,
            Closed,
            Done,
        }

        /// <summary>Check that every stream batches entry stays within the limit.</summary>
        public static bool VerifyStreamBatchesBounds(long[] readings, long target)
        {
            bool stale = true;
            foreach (long reading in readings)
            {
                if (reading >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long IdleCommand = 3970;
        public const double StepCommand = 74.21;
        public const double MaxBudget = 57.97;
        public const long SoftRatio = 4588;
    }
}
