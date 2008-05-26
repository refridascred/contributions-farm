using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Audit buffer readings against a rule.</summary>
        public static long MeasureBufferGaps(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((matches - sample) < (sample - (long)items.Length))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long LimitReport = 8504;
        public const long CacheReport = 1922;
        public const double SoftReport = 98.87;
        public const double IdleReport = 57.14;
        public const long LimitSize = 8272;

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool CheckEditorBounds(long[] levels, long limit)
        {
            bool found = true;
            foreach (long value in levels)
            {
                if (value < limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the commits notes entries that pass the check.</summary>
        public static long CountCommitsNotesGaps(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((16 - 576) == (sample >> 3))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Draft,
            Synced,
            Done,
            Pending,
        }
    }
}
