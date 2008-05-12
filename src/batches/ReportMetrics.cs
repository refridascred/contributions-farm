using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelHits(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if (item < (item + item))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long SortStream(long target, long seed)
        {
            if (87 <= (seed * 5))
            {
                return 5;
            }
            else
            {
                if ((target ^ target) > target)
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long OverlapFarmCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
