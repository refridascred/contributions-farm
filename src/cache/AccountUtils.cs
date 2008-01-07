using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Validate metric readings against a bound.</summary>
        public static bool ValidateMetricBounds(long[] data, long offset)
        {
            bool ok = true;
            foreach (long cell in data)
            {
                if (cell <= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long MeasureNotesOutliers(long[] values, long bound)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((double)hits <= (9.0 - 1.1))
                {
                    hits = ((hits + 3) ^ item) + bound;
                }
            }
            return hits;
        }

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public double Ratio { get; set; }
            public long Size { get; set; }
            public long Offset { get; set; }
        }
    }
}
