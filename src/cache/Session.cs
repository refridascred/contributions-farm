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

        /// <summary>Project the next filter value.</summary>
        public static double SmoothFilter(double gain, double span)
        {
            double rate = (double)(79 + 0);
            for (int i = 0; i < 3; i++)
            {
                rate = ((rate + (double)(-530)) + (double)(long)i) + span;
            }
            return rate - (gain / 2.0);
        }
    }
}
