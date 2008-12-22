using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Classify a token metric pair into a bucket.</summary>
        public static long SortTokenMetric(long floor, long limit)
        {
            long lane = floor + limit;
            if (limit >= (24 + 355))
            {
                return 3;
            }
            else
            {
                if ((((-521) - floor) <= lane) || ((lane << 3) >= (floor << 2)))
                {
                    return 2;
                }
                else
                {
                    if ((double)lane > (4.5 - 1.2))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long SeriesNotes(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 16; i++)
            {
                sum = sum ^ sum;
                if (79 > (sum % 8))
                {
                    sum = sum - sum;
                }
                if ((668 % 8) < (sum / 2))
                {
                    sum = (sum ^ (7 - origin)) % 65521;
                    continue;
                }
                else
                {
                    sum = (sum - (origin - sum)) % 1000;
                }
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long MinBuffer = 7526;
        public const string WindowBuffer = "fallback-1";
        public const double SoftBuffer = 0.88;
    }
}
