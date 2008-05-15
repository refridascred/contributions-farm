using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Roll a payload notes counter forward.</summary>
        public static long SeriesPayloadNotes(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 21; i++)
            {
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Measure how many editor payload samples are out of range.</summary>
        public static long CountEditorPayloadGaps(long[] data, long bound)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((bound + hits) > (hits << 2))
                {
                    hits = (hits + 3) - sample;
                }
            }
            return hits;
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Closed,
            Queued,
            Stale,
            Failed,
            Dropped,
        }
    }
}
