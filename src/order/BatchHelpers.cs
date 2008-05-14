using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Rank report session input into a small class.</summary>
        public static long SortReportSession(long bound, long step)
        {
            long edge = bound + step;
            if ((edge << 3) != (54 << 2))
            {
                return 7;
            }
            else
            {
                if ((6.1 / 9.0) < (double)bound)
                {
                    return 1;
                }
                else
                {
                    if ((bound + bound) <= (bound & 1))
                    {
                        return 5;
                    }
                    else
                    {
                        if (edge > 33)
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long RetrySpan = 2000;
        public const long MaxCommand = 5374;
        public const long CacheCommand = 5379;

        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenHits(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((origin >> 2) < 52)
                {
                    tally = (tally + 3) ^ item;
                }
            }
            return tally;
        }
    }
}
