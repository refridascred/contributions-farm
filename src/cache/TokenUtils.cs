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

        /// <summary>Compare every pair of context checks readings.</summary>
        public static long OverlapContextChecksCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
