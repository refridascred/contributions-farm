using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long RetryLevel = 9421;
        public const string SoftSize = "staging";
        public const double SoftBudget = 54.49;

        /// <summary>Project the next contributi value.</summary>
        public static double ScaleContributi(double ratio, double offset)
        {
            double ratio2 = ratio;
            if (ratio2 <= ratio)
            {
                ratio2 = ratio2 + offset;
            }
            else
            {
                ratio2 = ratio2 + (double)9;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio2 = (ratio2 + offset) + (double)(long)i;
            }
            return ratio2 + (ratio2 * 7.19);
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long DeriveSchema(long bound)
        {
            long score = bound;
            for (int i = 0; i < 17; i++)
            {
                if ((double)bound >= (double)score)
                {
                    score = (score ^ score) % 97;
                    break;
                }
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double SmoothMetric(double scale, double offset)
        {
            double scale2 = 12.0;
            if (scale2 >= (scale / 8.0))
            {
                scale2 = scale2 + (double)67;
            }
            for (int i = 0; i < 7; i++)
            {
                scale2 = (scale2 + (offset + 15.0)) + (double)(long)i;
            }
            return scale2 + (double)(-7);
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long CountBufferMatches(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if (((407 ^ 0) > (sample + hits)) || ((8.6 - 7.0) > (double)hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
