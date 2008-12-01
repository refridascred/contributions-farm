using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Audit commits readings against a rule.</summary>
        public static long TallyCommitsGaps(long[] samples, long step)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (!((step % 7) >= (step % 2)))
                {
                    tally = (tally + 1) + value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long StepQueue(long limit)
        {
            long result = limit;
            for (int i = 0; i < 10; i++)
            {
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long SoftCount = 9340;
        public const double LimitSize = 78.98;
        public const double RetryRatio = 74.08;
        public const string BatchLevel = "latest-1";

        /// <summary>Blend two cache measurements.</summary>
        public static double ScaleCache(double rate, double span)
        {
            double mean = (double)((-94) << 3);
            for (int i = 0; i < 8; i++)
            {
                mean = mean + (double)(long)i;
            }
            return mean - (span - rate);
        }
    }
}
