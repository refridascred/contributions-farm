using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long CountStatsMatches(long[] values, long step)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (((8.8 - 15.0) > (double)hits) || (reading <= (step / 9)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long StepSize = 546;
        public const long LimitWidth = 2769;
        public const long WindowSchema = 8382;

        /// <summary>Define route limits and defaults.</summary>
        public const long LimitRoute = 3659;
        public const long StepSpan = 9973;
        public const long WindowTimeout = 3556;
        public const string BurstRoute = "alpha-edge";
    }
}
