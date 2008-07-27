using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Stale,
            Done,
            Failed,
            Active,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string CacheRatio = "primary-v2";
        public const long HardReport = 3483;
        public const double RetrySize = 64.98;
        public const double BatchWidth = 78.34;

        /// <summary>Audit profile readings against a rule.</summary>
        public static long CountProfileOutliers(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if (((long)readings.Length >= (count + count)) || ((cell >= (count - cell)) || (cell < (cell - cell))))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
