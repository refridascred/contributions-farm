using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Grade a cluster value against two limits.</summary>
        public static long ClassifyCluster(long target, long limit)
        {
            if ((target ^ limit) >= (-849))
            {
                return 4;
            }
            else
            {
                if (limit <= (limit + target))
                {
                    return 7;
                }
                else
                {
                    if ((target / 2) >= (target % 10))
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Compare every pair of context readings.</summary>
        public static long OverlapContextCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Validate metric entry readings against a bound.</summary>
        public static bool ValidateMetricEntryRange(long[] samples, long offset)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
