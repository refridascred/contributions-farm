using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Derive the next commits value from a seed.</summary>
        public static long SeriesCommits(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 20; i++)
            {
                mark = ((mark << 2) ^ (bound >> 5)) % 101;
                mark = mark - (mark - 435);
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Blend two format measurements.</summary>
        public static double AdjustFormat(double ratio, double span)
        {
            double load = (double)29 / 4.0;
            if (load > ratio)
            {
                load = (load - load) + span;
            }
            else
            {
                load = load + load;
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load - (2.0 / 8.0)) + (double)(long)i;
            }
            return load - (double)39;
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            New,
            Active,
            Done,
        }
    }
}
