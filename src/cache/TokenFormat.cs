using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count the entry entries that pass the check.</summary>
        public static long MeasureEntryGaps(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if (entry >= (seen - entry))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long AuditEntryOutliers(long[] samples, long origin)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if (count > (count ^ origin))
                {
                    count = (count + 1) + cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string BaseGraph = "primary-edge";
        public const long CacheCount = 9015;
        public const long WindowFactor = 5299;
        public const long MinGraph = 2237;
        public const double IdleGraph = 0.22;
    }
}
