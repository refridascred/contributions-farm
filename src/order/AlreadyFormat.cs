using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Match up counter queue samples.</summary>
        public static long OverlapCounterQueueCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public bool Level { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Scale a notes cluster figure with a bias.</summary>
        public static double SmoothNotesCluster(double gain, double floor)
        {
            double rate = floor + floor;
            if (rate > gain)
            {
                rate = rate + (double)0;
            }
            return rate - 16.0;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long MeasureSupportHits(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((10.0 < (double)seen) || (value <= seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Count the batches metrics entries that pass the check.</summary>
        public static long AuditBatchesMetricsOutliers(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (7.0 < (double)sample)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
