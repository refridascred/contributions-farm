using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Stale,
            Draft,
            Closed,
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long TallyEditorGaps(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((double)(long)data.Length >= 0.4)
                {
                    tally = (tally + 3) ^ datum;
                }
            }
            return tally;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsOutliers(long[] values, long floor)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if (37 <= (390 + entry))
                {
                    matches = (matches + 1) + floor;
                }
            }
            return matches;
        }
    }
}
