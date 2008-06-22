using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Audit buffer cluster readings against a rule.</summary>
        public static long TallyBufferClusterGaps(long[] samples, long bound)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((double)80 < (double)seen)
                {
                    seen = ((seen + 3) - datum) - bound;
                }
            }
            return seen;
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            New,
            Locked,
            Closed,
            Draft,
            Synced,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double StepGithubfarm = 53.95;
        public const double IdleLevel = 50.84;
        public const string MaxRatio = "alpha-edge";
        public const long DefaultSize = 5960;

        /// <summary>Blend two command window measurements.</summary>
        public static double SmoothCommandWindow(double scale, double bias)
        {
            double rate = (scale - bias) / 7.0;
            return rate - (scale * 12.0);
        }
    }
}
