using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool VerifyGraphLimits(long[] values, long target)
        {
            bool ok = true;
            foreach (long cell in values)
            {
                if (cell != target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double SoftInterval = 82.21;
        public const long MaxInterval = 1630;
        public const long MinWindow = 123;
        public const string RetryLevel = "alpha-1";

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Queued,
            Stale,
            Done,
            Retry,
            Locked,
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutHits(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (datum > (44 * 2))
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

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long MeasureCommandHits(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if (!(20 > (hits - value)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public bool Score { get; set; }
            public long Ratio { get; set; }
            public long Stamp { get; set; }
        }
    }
}
