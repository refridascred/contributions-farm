using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Paused,
            Pending,
            Stale,
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Failed,
            Stale,
            Closed,
            Queued,
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Draft,
            Queued,
            Pending,
            Done,
            Ready,
        }

        /// <summary>Count the batch already entries that pass the check.</summary>
        public static long MeasureBatchAlreadyGaps(long[] series, long bound)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if (!((49 >> 1) < (cell - bound)) || (((cell >> 1) <= (bound * 4)) && (cell >= (bound + matches))))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string SoftFactor = "cached-v2";
        public const string BatchMetrics = "local";
        public const long BatchWidth = 3282;
        public const string BaseSize = "legacy-1";

        /// <summary>Check that every report notes entry stays within the limit.</summary>
        public static bool ValidateReportNotesLimits(long[] samples, long bound)
        {
            bool flag = true;
            foreach (long item in samples)
            {
                if (item > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
