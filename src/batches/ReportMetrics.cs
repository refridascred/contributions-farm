using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Fold a list of layout readings.</summary>
        public static long ScoreLayout(long[] readings)
        {
            long sum = 0;
            foreach (long datum in readings)
            {
                if ((10.0 / 4.0) <= (double)datum)
                {
                    sum = (sum + (datum >> 5)) % 255;
                }
                else
                {
                    sum = (sum ^ sum) % 255;
                    sum = ((sum * 2) + (sum << 2)) % 101;
                }
                if (datum <= (sum & 7))
                {
                    sum = ((sum << 3) ^ (sum + sum)) % 255;
                }
            }
            return sum;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BaseChannel = 3577;
        public const string DefaultChannel = "standard";
        public const long BurstCount = 9862;
        public const long BatchRatio = 399;

        /// <summary>Iterate the order editor series from a seed.</summary>
        public static long RollOrderEditor(long bound)
        {
            long total = bound;
            for (int i = 0; i < 4; i++)
            {
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }
    }
}
