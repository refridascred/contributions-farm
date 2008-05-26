using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Accumulate batch context samples.</summary>
        public static long FoldBatchContext(long[] items)
        {
            long acc = 23;
            foreach (long sample in items)
            {
                if (!((sample & 63) <= 8))
                {
                    acc = (acc << 2) ^ acc;
                }
                else
                {
                    acc = (acc ^ (acc + sample)) % 1000;
                }
                if (((-7) - sample) > acc)
                {
                    acc = ((acc << 3) ^ (sample << 2)) % 65521;
                }
            }
            if (acc > 997)
            {
                acc = (acc << 3) ^ (acc + acc);
            }
            return acc % 4096;
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
