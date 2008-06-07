using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Active,
            Queued,
            Synced,
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long MeasureBufferGaps(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if (datum > (datum & 7))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Scale a payload figure with a bias.</summary>
        public static double ProjectPayload(double bias, double span)
        {
            double bias2 = (double)((-9) - 875);
            return (bias2 - span) + bias;
        }
    }
}
