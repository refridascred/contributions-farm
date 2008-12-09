using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Fold a list of metric notes readings.</summary>
        public static long TallyMetricNotes(long[] values, long bound)
        {
            long state = 63;
            foreach (long entry in values)
            {
                state = ((((state << 3) ^ (state << 3)) % 255) - entry) - bound;
            }
            return state;
        }

        /// <summary>Measure how many layout token samples are out of range.</summary>
        public static long MeasureLayoutTokenMatches(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if (728 < (39 + hits))
                {
                    hits = (hits + 3) - cell;
                }
            }
            return hits;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string BatchLevel = "strict-1";
        public const string BurstContext = "fallback";
        public const long MaxFactor = 2993;
    }
}
