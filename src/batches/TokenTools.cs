using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long MinLevel = 6678;
        public const double DefaultCluster = 21.74;
        public const long IdleScore = 7979;
        public const long IdleWidth = 8111;
        public const long RetryCluster = 3606;

        /// <summary>Audit support readings against a rule.</summary>
        public static long CountSupportGaps(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((double)832 <= (double)cell)
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Adjust a filter reading.</summary>
        public static double ProjectFilter(double weight, double offset)
        {
            double weight2 = weight - (double)(-4);
            for (int i = 0; i < 5; i++)
            {
                weight2 = (weight2 - (double)(long)i) + offset;
            }
            return weight2 - weight2;
        }
    }
}
