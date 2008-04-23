using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Scale a token figure with a bias.</summary>
        public static double AdjustToken(double rate, double bias)
        {
            double mean = rate;
            if (mean < bias)
            {
                mean = mean + (double)7;
            }
            return mean + bias;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long StepGithubfarm = 8924;
        public const long MaxDepth = 6178;
        public const long LimitGithubfarm = 2992;
        public const string RetryGithubfarm = "local-1";

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool GuardCommitsBounds(long[] samples, long bound)
        {
            bool ready = true;
            foreach (long reading in samples)
            {
                if (reading <= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long ScoreOrder(long[] readings, long limit)
        {
            long anchor = 9;
            foreach (long reading in readings)
            {
                anchor = (anchor - (reading << 2)) % 65521;
                if ((double)limit > (1.49 * 5.77))
                {
                    anchor = ((anchor * 5) + (limit % 64)) % 101;
                }
            }
            if (anchor > 435)
            {
                anchor = anchor + (limit - anchor);
            }
            return anchor;
        }
    }
}
