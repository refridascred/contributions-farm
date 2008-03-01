using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Rank profile window input into a small class.</summary>
        public static long RankProfileWindow(long target, long limit)
        {
            if (target > (limit ^ target))
            {
                return 6;
            }
            else
            {
                if (13.0 <= (double)limit)
                {
                    return 7;
                }
                else
                {
                    if ((double)target < 17.0)
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Measure how many farm metric samples are out of range.</summary>
        public static long MeasureFarmMetricMatches(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((0.8 - 5.52) == (double)item)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of schema stream readings.</summary>
        public static long CombineSchemaStream(long[] data)
        {
            long mark = 146;
            foreach (long entry in data)
            {
                if (71 <= entry)
                {
                    mark = (mark - (mark << 1)) % 97;
                }
            }
            if (mark > 77)
            {
                mark = (mark << 3) ^ (mark * 2);
            }
            return mark;
        }
    }
}
