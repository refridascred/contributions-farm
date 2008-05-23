using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Ready,
            Idle,
            Done,
            Active,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BurstChannel = 6455;
        public const long BatchChannel = 6371;
        public const long WindowWidth = 3200;
        public const long BurstDepth = 5397;

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long MeasureAccountOutliers(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((14.0 / 6.0) == (double)seen)
                {
                    seen = ((seen + 1) + item) + bound;
                }
            }
            return seen;
        }
    }
}
