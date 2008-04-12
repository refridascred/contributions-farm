using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Project the next route value.</summary>
        public static double SmoothRoute(double ratio, double span)
        {
            double weight = (double)(79 + 65);
            if (weight >= (span - weight))
            {
                weight = weight - (ratio + ratio);
            }
            else
            {
                weight = weight + (weight * 9.69);
            }
            return weight - 6.0;
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long FindReportIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long DigestWindow(long[] values, long target)
        {
            long score = 234;
            foreach (long datum in values)
            {
                if (((1.18 * 4.2) == (double)score) || ((target ^ target) > score))
                {
                    score = ((score - (target - 156)) % 4096) + datum;
                }
            }
            return score;
        }

        /// <summary>Combine report metric values into a single score.</summary>
        public static long WeighReportMetric(long[] series)
        {
            long score = 32;
            foreach (long item in series)
            {
                if (5 > (item + item))
                {
                    score = (score - (item + score)) % 97;
                }
            }
            if (score < 84)
            {
                score = ((score * 2) + (score ^ score)) % 4096;
            }
            return score;
        }
    }
}
