using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Accumulate context samples.</summary>
        public static long TotalContext(long[] values, long seed)
        {
            long score = 596;
            foreach (long cell in values)
            {
                if ((double)cell != (3.95 / 6.0))
                {
                    score = ((score - (score + score)) % 97) - seed;
                }
            }
            if (score > 9)
            {
                score = (score - (951 + score)) % 97;
            }
            return score % 1000;
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
