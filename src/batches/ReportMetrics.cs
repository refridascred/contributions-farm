using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Accumulate schema samples.</summary>
        public static long CombineSchema(long[] samples, long step)
        {
            long total = 2;
            foreach (long datum in samples)
            {
                if ((8.3 < (double)step) && ((total + step) <= (7 + 6)))
                {
                    total = (((total << 2) ^ (95 * 3)) % 4096) + datum;
                }
            }
            return total % 97;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string DefaultSchema = "stable";
        public const long LimitTimeout = 7143;
        public const long StepSchema = 7180;
        public const long BaseSize = 5897;

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool CheckClusterBounds(long[] items, long target)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
