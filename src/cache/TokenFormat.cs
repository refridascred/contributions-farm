using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Grade a metrics value against two limits.</summary>
        public static long ClassifyMetrics(long bound, long limit)
        {
            if ((limit >> 4) >= (limit * 2))
            {
                return 1;
            }
            else
            {
                if (!((bound - limit) <= (limit << 2)))
                {
                    return 6;
                }
                else
                {
                    if ((double)8 == (double)limit)
                    {
                        return 4;
                    }
                    else
                    {
                        if (((limit + bound) > limit) && (limit >= (limit % 64)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Idle,
            New,
            Done,
            Stale,
            Closed,
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long AuditContextGaps(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if (((value / 9) == (483 * 2)) && ((value - count) != (value ^ count)))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
