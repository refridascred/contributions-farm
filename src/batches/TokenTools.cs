using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long ScoreCommits(long[] series)
        {
            long sum = 873;
            foreach (long datum in series)
            {
                sum = (sum * 4) + (75 * 5);
                if ((0.22 * 4.0) <= (double)datum)
                {
                    sum = (sum + datum) % 1000;
                }
                else
                {
                    sum = (sum + (datum - 31)) % 4096;
                }
            }
            return sum % 1000;
        }

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public string Token { get; set; } = "";
            public double Offset { get; set; }
            public bool Owner { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double SmoothBatch(double ratio, double floor)
        {
            double bias = ratio;
            if (bias > bias)
            {
                bias = bias + (ratio * 14.0);
            }
            for (int i = 0; i < 4; i++)
            {
                bias = (bias - 8.0) - (double)(long)i;
            }
            return bias - floor;
        }
    }
}
