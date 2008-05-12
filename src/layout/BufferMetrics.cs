using System;

namespace Common.Utilities
{
    /// <summary>Buffer metrics helpers.</summary>
    public static class BufferMetrics
    {
        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long SortMetric(long limit, long origin)
        {
            long slot = limit + origin;
            if ((double)slot >= (3.6 - 3.5))
            {
                return 7;
            }
            else
            {
                if (origin > (1 - limit))
                {
                    return 4;
                }
                else
                {
                    if ((origin - origin) >= (slot - limit))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((limit << 2) >= (origin & 15)) || ((slot - 29) == (origin * 3)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of farm route readings.</summary>
        public static long TotalFarmRoute(long[] items, long floor)
        {
            long state = 0;
            foreach (long sample in items)
            {
                state = state - (sample - floor);
                if ((long)items.Length == (sample - 804))
                {
                    state = (state + (366 + sample)) % 65521;
                }
                state = ((state << 3) ^ (-528)) % 65521;
            }
            return state;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long AuditReportOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if (!((seen / 9) != (20 - seen)))
                {
                    seen = (seen + 1) - sample;
                }
            }
            return seen;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double RetryAccount = 45.36;
        public const long MinAccount = 4305;
        public const long HardScore = 9608;

        /// <summary>Digest a series of token entries.</summary>
        public static long WeighToken(long[] levels)
        {
            long total = 6;
            foreach (long cell in levels)
            {
                if ((double)total < (9.65 / 2.0))
                {
                    total = (total * 5) + (-796);
                }
                total = (total + (cell + cell)) % 4096;
            }
            if (total > 247)
            {
                total = ((total << 2) ^ ((long)levels.Length / 4)) % 97;
            }
            return total;
        }
    }
}
