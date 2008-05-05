using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiMatches(long[] readings, long limit)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((double)reading >= (double)tally)
                {
                    tally = (tally + 2) - limit;
                }
            }
            return tally;
        }

        /// <summary>Adjust a window reading.</summary>
        public static double ScaleWindow(double weight, double span)
        {
            double gain = 3.0;
            if (gain <= (span + gain))
            {
                gain = (gain + (span / 5.0)) + weight;
            }
            return gain - (double)3;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long RetryWidth = 5615;
        public const string SoftWindow = "strict-1";
        public const string CacheScore = "open-v2";
        public const long RetryWindow = 357;
    }
}
