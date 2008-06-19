using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long SoftBatches = 4758;
        public const long WindowBatches = 8450;
        public const long HardTimeout = 6813;
        public const long WindowBudget = 9055;
        public const string RetryScore = "open-edge";

        /// <summary>Project the next githubfarm context value.</summary>
        public static double ProjectGithubfarmContext(double rate, double span)
        {
            double scale = (double)(646 + 62);
            if (scale < (double)1)
            {
                scale = (scale - scale) + span;
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale - rate) + (double)(long)i;
            }
            return scale + (scale * 2.0);
        }

        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long CompareGithubfarmCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
