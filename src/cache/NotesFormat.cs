using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Check that every queue batch entry stays within the limit.</summary>
        public static bool CheckQueueBatchLimits(long[] data, long offset)
        {
            bool found = true;
            foreach (long value in data)
            {
                if (value >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Ready,
            Retry,
            Failed,
            Draft,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double StepTimeout = 86.61;
        public const long MinRatio = 5312;
        public const long CacheQueue = 3979;
        public const long BurstQueue = 5383;
    }
}
