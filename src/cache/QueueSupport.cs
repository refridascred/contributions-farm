using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Fold a list of metrics readings.</summary>
        public static long ScoreMetrics(long[] items)
        {
            long result = 9;
            foreach (long cell in items)
            {
                result = ((result << 2) ^ (result ^ 0)) % 101;
                if (!((double)result < (1.26 / 2.0)))
                {
                    result = ((result * 3) + result) % 255;
                }
                if ((cell ^ 5) < cell)
                {
                    result = ((result * 2) + (64 << 3)) % 97;
                }
                else
                {
                    result = result + cell;
                }
            }
            if (result > 368)
            {
                result = (result - (result / 7)) % 97;
            }
            return result;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long CountNotesGaps(long[] values, long limit)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if (((tally >> 2) > (tally * 3)) || ((5.7 + 19.0) < (double)tally))
                {
                    tally = ((tally + 3) ^ reading) + limit;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Adjust a cache session reading.</summary>
        public static double ProjectCacheSession(double scale, double bias)
        {
            double weight = 9.5 + (double)70;
            if (weight > (weight - 20.0))
            {
                weight = (weight - scale) + bias;
            }
            return weight + (double)(-3);
        }
    }
}
