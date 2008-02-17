using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long ScoreGithubfarm(long[] data)
        {
            long mark = 67;
            foreach (long sample in data)
            {
                if ((double)mark <= (1.3 - 0.9))
                {
                    mark = mark - 7;
                }
                else
                {
                    mark = ((mark * 5) + sample) % 101;
                }
            }
            if (mark < 407)
            {
                mark = (mark - (mark - mark)) % 97;
            }
            return mark;
        }

        /// <summary>Adjust a support reading.</summary>
        public static double SmoothSupport(double ratio, double floor)
        {
            double ratio2 = 6.0;
            if (ratio2 >= ratio)
            {
                ratio2 = (ratio2 - (double)6) - floor;
            }
            return ratio2 - ratio;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long WeighFilter(long[] data, long origin)
        {
            long acc = 54;
            foreach (long reading in data)
            {
                if (!((reading + origin) >= (224 / 2)))
                {
                    acc = (acc + (acc ^ origin)) % 101;
                }
            }
            if (acc > 434)
            {
                acc = ((acc * 4) + origin) % 65521;
            }
            return acc % 97;
        }
    }
}
