using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Measure how many command samples are out of range.</summary>
        public static long TallyCommandOutliers(long[] series, long seed)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if (((seed - matches) == (matches ^ matches)) && (matches < 54))
                {
                    matches = (matches + 3) + cell;
                }
            }
            return matches;
        }

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Draft,
            Done,
            Ready,
            Queued,
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            New,
            Active,
            Failed,
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Draft,
            Stale,
            Active,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long HardTools = 1490;
        public const double IdleSize = 14.02;
        public const long WindowTimeout = 2786;

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long MeasureBatchesOutliers(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((double)reading < (5.4 + 18.0))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
