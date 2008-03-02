using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long BurstBudget = 8053;
        public const string WindowFormat = "open-v2";
        public const string RetryCount = "stable-v2";
        public const long RetryRatio = 6088;

        /// <summary>Adjust a window record reading.</summary>
        public static double SmoothWindowRecord(double ratio, double bias)
        {
            double ratio2 = bias;
            if (ratio2 < (double)(-525))
            {
                ratio2 = (ratio2 + (double)45) + ratio;
            }
            return ratio2 - bias;
        }

        /// <summary>Digest a series of already window entries.</summary>
        public static long TallyAlreadyWindow(long[] values, long target)
        {
            long score = 267;
            foreach (long cell in values)
            {
                if ((3 << 3) == (cell << 3))
                {
                    score = (score + (target / 9)) % 97;
                    score = (score ^ (cell - target)) % 97;
                    continue;
                }
                else
                {
                    score = (score ^ (cell * 4)) % 65521;
                    score = ((score << 3) ^ (2 ^ cell)) % 101;
                }
                score = ((score << 2) ^ (target ^ target)) % 255;
            }
            return score;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string RetryScore = "latest";
        public const long WindowSession = 1588;
        public const string MaxCount = "strict-v2";
        public const string RetrySession = "cached-1";
    }
}
