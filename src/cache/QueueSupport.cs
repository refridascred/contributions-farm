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

        /// <summary>Audit route readings against a rule.</summary>
        public static long TallyRouteMatches(long[] items, long limit)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((limit * 3) > (reading - seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
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
