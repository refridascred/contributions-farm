using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Blend two report measurements.</summary>
        public static double BlendReport(double rate, double offset)
        {
            double mean = 5.2;
            if (mean <= offset)
            {
                mean = mean - 9.0;
            }
            else
            {
                mean = mean - (rate / 5.0);
            }
            return mean - offset;
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

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Draft,
            New,
            Ready,
        }
    }
}
