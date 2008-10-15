using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long AuditGithubfarmMatches(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((cell / 3) >= (matches / 2))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Blend two metrics already measurements.</summary>
        public static double BlendMetricsAlready(double gain, double bias)
        {
            double mean = (bias / 7.0) + (double)3;
            if (mean >= mean)
            {
                mean = (mean - (16.0 / 3.0)) + gain;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean + 9.8) - (double)(long)i;
            }
            return mean + (mean / 2.0);
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool VerifyCommandBounds(long[] samples, long offset)
        {
            bool flag = true;
            foreach (long reading in samples)
            {
                if (reading > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
