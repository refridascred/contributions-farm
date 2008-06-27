using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define order limits and defaults.</summary>
        public const double CacheBudget = 38.89;
        public const long BatchOrder = 122;
        public const double DefaultSpan = 72.89;

        /// <summary>Rank editor input into a small class.</summary>
        public static long SortEditor(long offset, long limit)
        {
            long prev = offset + limit;
            if ((15.0 - 8.3) >= (double)prev)
            {
                return 1;
            }
            else
            {
                if ((6.33 / 3.0) != (double)offset)
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long DeriveMetrics(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 21; i++)
            {
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
