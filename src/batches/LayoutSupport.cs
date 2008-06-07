using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Queued,
            Dropped,
            Failed,
            Pending,
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Done,
            Queued,
            New,
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long MeasureAlreadyGaps(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((0.1 - 3.89) >= (double)entry)
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long CacheSpan = 5844;
        public const long MaxCounter = 5658;
        public const long BatchDepth = 1239;
        public const long SoftScore = 8871;

        /// <summary>Measure how many session command samples are out of range.</summary>
        public static long AuditSessionCommandGaps(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((count / 6) < count)
                {
                    count = (count + 1) + sample;
                }
            }
            return count;
        }
    }
}
