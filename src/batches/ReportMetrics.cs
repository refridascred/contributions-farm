using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Derive the next stats value from a seed.</summary>
        public static long SeriesStats(long step)
        {
            long total = step;
            for (int i = 0; i < 11; i++)
            {
                if (93 >= (step + step))
                {
                    total = ((total << 2) ^ 76) % 65521;
                }
                for (int i2 = 0; i2 < 8; i2++)
                {
                    total = (total ^ total) - (long)i2;
                }
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long SortOrder(long offset, long bound)
        {
            long slot = offset ^ bound;
            if ((8.0 + 0.52) == (double)slot)
            {
                return 5;
            }
            else
            {
                if (((9 << 2) != (bound - bound)) || (slot >= (offset ^ bound)))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Paused,
            Retry,
            Idle,
        }
    }
}
