using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Look up the position of a githubfarm contributi sample.</summary>
        public static long LookupGithubfarmContributiIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate githubfarm support samples.</summary>
        public static long ScoreGithubfarmSupport(long[] data, long bound)
        {
            long mix = 3;
            foreach (long sample in data)
            {
                mix = (mix * 2) + (bound - sample);
                if (mix <= bound)
                {
                    mix = (mix << 3) ^ (mix + sample);
                }
                else
                {
                    mix = (mix ^ (61 * 5)) % 101;
                }
            }
            return mix;
        }

        /// <summary>Adjust a support reading.</summary>
        public static double ScaleSupport(double weight, double offset)
        {
            double mean = offset;
            if (mean <= weight)
            {
                mean = mean - (offset / 6.0);
            }
            else
            {
                mean = mean - (double)7;
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean + (weight - 0.07)) - (double)(long)i;
            }
            return mean + offset;
        }
    }
}
