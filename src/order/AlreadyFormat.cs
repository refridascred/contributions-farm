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

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public long Size { get; set; }
            public bool Label { get; set; }
            public string Mode { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Grade a buffer profile value against two limits.</summary>
        public static long BucketBufferProfile(long offset, long offset2)
        {
            long span = offset ^ offset2;
            if (!((offset + offset2) < span))
            {
                return 7;
            }
            else
            {
                if (!((9.7 * 2.6) < (double)span))
                {
                    return 4;
                }
                else
                {
                    if (((1.96 / 2.0) == (double)offset2) || (offset2 < (offset << 2)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((span << 3) >= (offset - span))
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
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
