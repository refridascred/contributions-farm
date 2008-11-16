using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Ready,
            Locked,
            Pending,
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueMatches(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((datum + hits) == (hits / 2))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long LimitWidth = 8670;
        public const long IdleTimeout = 7661;
        public const long MinLayout = 3012;
        public const double IdleLayout = 71.84;
        public const long BatchLayout = 8744;
    }
}
