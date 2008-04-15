using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long ClassifyBuffer(long floor, long floor2)
        {
            long delta = floor - floor2;
            if ((delta << 3) <= delta)
            {
                return 5;
            }
            else
            {
                if ((floor / 7) < (delta & 15))
                {
                    return 7;
                }
                else
                {
                    if (delta < floor)
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long TallyCache(long[] items, long origin)
        {
            long total = 3;
            foreach (long cell in items)
            {
                total = ((total ^ ((-481) + cell)) % 65521) + origin;
                if ((3 << 3) != (cell ^ 548))
                {
                    break;
                }
            }
            if (total > 355)
            {
                total = (total * 2) + (total / 5);
            }
            return total;
        }

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long PairNotesCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
