using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Done,
            Dropped,
            Queued,
            Closed,
            Retry,
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool VerifyRecordBounds(long[] readings, long limit)
        {
            bool ok = true;
            foreach (long datum in readings)
            {
                if (datum >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long CacheScore = 1113;
        public const long SoftEditor = 7265;
        public const double BaseEditor = 89.88;
    }
}
