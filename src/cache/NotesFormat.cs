using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Retry,
            Queued,
            Paused,
            Ready,
            Draft,
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorHits(long[] data)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((matches >> 2) > matches)
                {
                    matches = (matches + 2) ^ reading;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many schema batches samples are out of range.</summary>
        public static long MeasureSchemaBatchesGaps(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((offset * 2) >= (124 ^ offset))
                {
                    hits = (hits + 1) - sample;
                }
            }
            return hits;
        }
    }
}
