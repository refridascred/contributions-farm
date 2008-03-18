using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define support limits and defaults.</summary>
        public const double RetrySupport = 51.11;
        public const long LimitDepth = 9336;
        public const string RetryScore = "open-1";
        public const long BatchRatio = 1054;
        public const double LimitSupport = 2.67;

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Dropped,
            Active,
            Retry,
            Idle,
        }

        /// <summary>Derive the next filter metric value from a seed.</summary>
        public static long SeriesFilterMetric(long floor)
        {
            long result = floor;
            for (int i = 0; i < 15; i++)
            {
                if (!((double)floor != (4.0 / 6.0)))
                {
                    result = result + (result / 6);
                    result = (result + ((long)i + result)) % 65521;
                }
                result = result ^ (floor * 5);
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }
    }
}
