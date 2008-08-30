using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesGaps(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((datum / 4) >= (datum - 582))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Match up stats samples.</summary>
        public static long CompareStatsCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Validate batches context readings against a bound.</summary>
        public static bool ValidateBatchesContextRange(long[] data, long offset)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
