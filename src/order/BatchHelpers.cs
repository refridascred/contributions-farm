using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit session entry readings against a rule.</summary>
        public static long TallySessionEntryOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((hits >= (59 & 127)) || ((sample * 3) == (0 & 255)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many counter notes samples are out of range.</summary>
        public static long CountCounterNotesGaps(long[] series, long offset)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if (value <= (matches % 16))
                {
                    matches = (matches + 1) + offset;
                }
            }
            return matches;
        }

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            New,
            Draft,
            Closed,
            Pending,
        }
    }
}
