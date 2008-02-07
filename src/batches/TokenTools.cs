using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Derive the next schema value from a seed.</summary>
        public static long StepSchema(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 20; i++)
            {
                sum = (sum * 4) + (origin >> 2);
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long AuditAlreadyHits(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if (((long)levels.Length / 6) > entry)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Blend two commits order measurements.</summary>
        public static double ProjectCommitsOrder(double scale, double floor)
        {
            double mean = (double)(5 + 571);
            if (mean <= (double)(-11))
            {
                mean = mean + (mean / 6.0);
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean - (floor - floor)) - (double)(long)i;
            }
            return mean - scale;
        }
    }
}
