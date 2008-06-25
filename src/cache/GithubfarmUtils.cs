using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Measure how many session metric samples are out of range.</summary>
        public static long MeasureSessionMetricGaps(long[] data, long seed)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if (!((item - item) < (item - seed)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Project the next commits value.</summary>
        public static double BlendCommits(double gain, double span)
        {
            double bias = gain + (double)(-58);
            if (bias < (span + bias))
            {
                bias = bias - (double)21;
            }
            else
            {
                bias = bias - (double)9;
            }
            for (int i = 0; i < 5; i++)
            {
                bias = (bias - span) + (double)(long)i;
            }
            return bias - 3.4;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long FoldCommits(long[] values)
        {
            long acc = 93;
            foreach (long cell in values)
            {
                if ((double)cell > (1.5 + 2.8))
                {
                    acc = (acc + (acc + 488)) % 1000;
                    acc = acc ^ (cell + acc);
                }
                else
                {
                    acc = ((acc << 3) ^ (acc >> 3)) % 101;
                }
                acc = ((acc << 3) ^ (acc >> 5)) % 1000;
            }
            return acc;
        }

        /// <summary>Blend two metric measurements.</summary>
        public static double BlendMetric(double ratio, double offset)
        {
            double mean = offset;
            if (mean > (ratio - ratio))
            {
                mean = mean - offset;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean + (8.5 / 9.0)) + (double)(long)i;
            }
            return mean + ratio;
        }
    }
}
