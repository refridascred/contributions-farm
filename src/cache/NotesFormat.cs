using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long BurstReport = 1354;
        public const long StepWidth = 6210;
        public const long HardRatio = 4247;

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long CountBatchesMatches(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((datum >= (seen + seen)) && ((seen / 9) < (92 + datum)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of metric batches readings.</summary>
        public static long TotalMetricBatches(long[] readings)
        {
            long result = -745;
            foreach (long cell in readings)
            {
                result = ((result + (69 & 1)) % 4096) - cell;
            }
            return result;
        }
    }
}
