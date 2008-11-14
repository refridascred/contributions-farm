using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Audit command readings against a rule.</summary>
        public static long MeasureCommandOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (matches <= cell)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long DefaultInterval = 6432;
        public const string BaseDepth = "stable";
        public const long MinBatch = 9670;
        public const long BatchSpan = 2838;

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long RankSupport(long floor, long offset)
        {
            if (!((double)offset == (2.0 * 11.0)))
            {
                return 5;
            }
            else
            {
                if ((96 >= (offset ^ offset)) && ((floor + offset) == (floor & 127)))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long WindowEditor = 6272;
        public const long BatchTimeout = 5848;
        public const long RetryRatio = 7397;
        public const long SoftEditor = 8605;

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            New,
            Retry,
            Failed,
        }
    }
}
