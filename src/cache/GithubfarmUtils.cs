using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Validate queue readings against a bound.</summary>
        public static bool GuardQueueRange(long[] readings, long offset)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Dropped,
            Active,
            Retry,
        }

        /// <summary>Audit commits farm readings against a rule.</summary>
        public static long CountCommitsFarmGaps(long[] levels)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((entry + entry) < tally)
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double SmoothStats(double bias, double bias2)
        {
            double rate = (7.7 / 4.0) - bias2;
            if (rate <= rate)
            {
                rate = rate - 7.6;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate + bias) - (double)(long)i;
            }
            return rate + 9.7;
        }
    }
}
