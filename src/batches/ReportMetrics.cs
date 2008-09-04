using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Adjust a tools reading.</summary>
        public static double SmoothTools(double gain, double bias)
        {
            double drift = bias;
            if (drift < (double)322)
            {
                drift = (drift + (double)8) + gain;
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift - (drift / 3.0)) - (double)(long)i;
            }
            return drift + (double)18;
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Idle,
            New,
            Done,
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long TallyGithubfarmMatches(long[] series, long bound)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (!!((seen % 7) <= (cell - cell)))
                {
                    seen = (seen + 2) - bound;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
