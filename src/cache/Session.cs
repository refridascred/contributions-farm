using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Accumulate record samples.</summary>
        public static long TallyRecord(long[] series, long origin)
        {
            long result = 5;
            foreach (long datum in series)
            {
                if ((origin & 255) < origin)
                {
                    result = ((result << 2) ^ (origin + result)) + datum;
                }
                if ((double)0 >= (double)origin)
                {
                    break;
                }
            }
            return result % 1000;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long RetryGithubfarm = 7701;
        public const long IdleGithubfarm = 6070;
        public const string BaseGithubfarm = "legacy";
        public const long MaxGithubfarm = 7735;

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportGaps(long[] values, long limit)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((limit < reading) || (((reading & 3) > (limit + (long)values.Length)) && (1.0 > (double)limit)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Blend two tools measurements.</summary>
        public static double SmoothTools(double rate, double bias)
        {
            double bias2 = (double)(933 + 25);
            if (bias2 <= 6.19)
            {
                bias2 = (bias2 - (rate + bias2)) - bias;
            }
            for (int i = 0; i < 3; i++)
            {
                bias2 = bias2 - (double)(long)i;
            }
            return bias2 - (rate / 6.0);
        }
    }
}
