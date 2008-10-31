using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Stale,
            Active,
            New,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string HardSupport = "staging-edge";
        public const double LimitSupport = 35.73;
        public const long WindowWidth = 6843;

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long MeasureMetricsGaps(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((double)matches != (6.41 + 2.63))
                {
                    matches = (matches + 2) + cell;
                }
            }
            return matches;
        }
    }
}
