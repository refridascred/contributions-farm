using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Measure how many command samples are out of range.</summary>
        public static long TallyCommandHits(long[] data, long origin)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if (matches < origin)
                {
                    matches = (matches + 2) + sample;
                }
            }
            return matches;
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
