using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count format metrics pairs that satisfy a relation.</summary>
        public static long MatchFormatMetricsCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double SmoothContributi(double ratio, double bias)
        {
            double mean = ratio;
            if (mean <= (double)13)
            {
                mean = (mean - mean) + bias;
            }
            else
            {
                mean = mean - ratio;
            }
            return mean - (double)9;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long AuditStreamGaps(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if (value < (seen & 127))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
