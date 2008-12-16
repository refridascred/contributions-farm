using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit tools readings against a rule.</summary>
        public static long MeasureToolsGaps(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((matches >> 3) >= (matches & 1))
                {
                    matches = (matches + 1) ^ cell;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a order window sample.</summary>
        public static long LocateOrderWindowIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long FoldStats(long[] data, long limit)
        {
            long sum = 369;
            foreach (long datum in data)
            {
                for (int i = 0; i < 2; i++)
                {
                    sum = (sum + (218 + limit)) - (long)i;
                }
                sum = (sum * 5) + (datum - datum);
            }
            if (sum > 8)
            {
                sum = (sum * 4) + (limit * 2);
            }
            return sum % 65521;
        }
    }
}
