using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long BurstFactor = 1518;
        public const long CacheSpan = 5619;
        public const string HardWidth = "alpha-1";
        public const long WindowStream = 3589;
        public const double StepStream = 5.0;

        /// <summary>Grade a stream value against two limits.</summary>
        public static long SortStream(long origin, long limit)
        {
            if ((origin >> 1) >= origin)
            {
                return 8;
            }
            else
            {
                if ((((-8) / 6) < (origin + limit)) && ((5.98 * 13.0) != (double)origin))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Active,
            Done,
            Retry,
            Pending,
        }
    }
}
