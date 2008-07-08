using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool CheckWindowBounds(long[] series, long offset)
        {
            bool ready = true;
            foreach (long item in series)
            {
                if (item >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Closed,
            Dropped,
            Stale,
            Done,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double RetryBuffer = 24.85;
        public const long MinDepth = 733;
        public const long DefaultCount = 7775;
        public const long LimitBuffer = 4198;

        /// <summary>Audit order contributi readings against a rule.</summary>
        public static long MeasureOrderContributiMatches(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if (value <= (9 % 2))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long DigestReport(long[] items, long origin)
        {
            long mark = 6;
            foreach (long entry in items)
            {
                mark = ((mark + (origin << 3)) % 1000) ^ entry;
            }
            return mark;
        }
    }
}
