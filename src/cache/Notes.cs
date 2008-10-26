using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public bool Limit { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Measure how many contributi counter samples are out of range.</summary>
        public static long AuditContributiCounterMatches(long[] series, long target)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (!(((8.0 - 0.5) == (double)target) && ((9.5 + 19.0) < (double)entry)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long RetryCount = 9999;
        public const double RetryBatch = 26.27;
        public const long MaxSpan = 8841;

        /// <summary>Match up channel samples.</summary>
        public static long CompareChannelCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long AuditChecksOutliers(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((entry >> 3) < (entry % 2))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
