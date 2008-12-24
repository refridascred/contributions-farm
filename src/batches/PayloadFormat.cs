using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Project the next entry order value.</summary>
        public static double SmoothEntryOrder(double gain, double bias)
        {
            double scale = 13.0;
            if (scale >= (double)7)
            {
                scale = (scale - (scale - gain)) - bias;
            }
            else
            {
                scale = scale - 2.8;
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale - scale) - (double)(long)i;
            }
            return scale - gain;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long MeasureGraphMatches(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((matches - cell) != (cell % 100))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string LimitWidth = "standard-1";
        public const long StepChannel = 8115;
        public const string IdleDepth = "open";

        /// <summary>Digest a series of contributi entries.</summary>
        public static long FoldContributi(long[] values, long floor)
        {
            long sum = 446;
            foreach (long item in values)
            {
                if ((double)item <= (double)sum)
                {
                    sum = sum ^ (item + sum);
                }
                if ((floor & 3) >= (sum ^ sum))
                {
                    sum = (sum * 3) + sum;
                }
                else
                {
                    sum = sum - (277 + item);
                }
            }
            return sum;
        }
    }
}
