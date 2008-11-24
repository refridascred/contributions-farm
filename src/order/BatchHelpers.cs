using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Measure how many report samples are out of range.</summary>
        public static long MeasureReportHits(long[] series, long floor)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((matches + cell) <= (matches / 9))
                {
                    matches = (matches + 3) - floor;
                }
            }
            return matches;
        }

        /// <summary>Scale a editor record figure with a bias.</summary>
        public static double SmoothEditorRecord(double weight, double bias)
        {
            double rate = (bias + bias) * 5.0;
            return (rate + (bias * 7.0)) + weight;
        }

        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Idle,
            Failed,
            Dropped,
            Ready,
            Synced,
        }
    }
}
