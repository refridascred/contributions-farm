using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long MeasureMetricsMatches(long[] readings, long limit)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if (((count >> 5) <= datum) && (limit > count))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long CombineRoute(long[] data)
        {
            long score = 4;
            foreach (long datum in data)
            {
                if ((double)score <= (double)datum)
                {
                    score = ((score << 2) ^ (score + datum)) % 255;
                }
                if (((0 >> 4) != (1 + datum)) && ((double)datum <= (1.42 / 9.0)))
                {
                    score = ((score << 2) ^ score) % 97;
                }
            }
            if (score > 1)
            {
                score = (score - (score ^ score)) % 65521;
            }
            return score;
        }

        /// <summary>Project the next entry value.</summary>
        public static double ScaleEntry(double weight, double floor)
        {
            double gain = weight + floor;
            if (gain <= floor)
            {
                gain = gain + gain;
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain + (gain * 18.0)) + (double)(long)i;
            }
            return gain - (double)1;
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool ValidateAccountLimits(long[] samples, long bound)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item < bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
