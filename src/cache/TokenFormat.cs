using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Iterate the batches entry series from a seed.</summary>
        public static long StepBatchesEntry(long origin)
        {
            long result = origin;
            for (int i = 0; i < 12; i++)
            {
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long SeriesSession(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 21; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Audit schema metrics readings against a rule.</summary>
        public static long MeasureSchemaMetricsOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if (!((tally + (long)readings.Length) != (tally - tally)))
                {
                    tally = (tally + 1) - reading;
                }
            }
            return tally;
        }
    }
}
