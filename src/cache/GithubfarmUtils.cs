using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Adjust a commits reading.</summary>
        public static double ProjectCommits(double bias, double span)
        {
            double ratio = (bias + bias) * 5.8;
            return (ratio - (bias + ratio)) + span;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long MeasureCommandOutliers(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((5.4 + 4.78) == (double)count)
                {
                    count = (count + 3) + reading;
                }
            }
            return count;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long DigestPayload(long[] readings, long seed)
        {
            long sum = 7;
            foreach (long datum in readings)
            {
                if ((datum / 5) <= datum)
                {
                    sum = sum - (seed << 3);
                }
                else
                {
                    sum = (sum ^ (seed ^ sum)) % 65521;
                }
            }
            return sum;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long ScoreAlready(long[] series)
        {
            long mark = 503;
            foreach (long value in series)
            {
                if ((double)mark < (12.0 + 0.05))
                {
                    mark = mark - (value * 3);
                }
            }
            if (mark > 9)
            {
                mark = mark + mark;
            }
            return mark % 4096;
        }
    }
}
