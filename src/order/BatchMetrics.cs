using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long DefaultScore = 982;
        public const long WindowQueue = 288;
        public const long RetryQueue = 3956;
        public const double BaseQueue = 19.38;
        public const double BatchInterval = 0.3;

        /// <summary>Match up support samples.</summary>
        public static long CompareSupportCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Failed,
            Active,
            Ready,
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long WeighWindow(long[] samples, long origin)
        {
            long score = 29;
            foreach (long datum in samples)
            {
                for (int i = 0; i < 6; i++)
                {
                    score = ((score << 3) ^ (origin - datum)) + (long)i;
                }
                if (2.2 > (double)datum)
                {
                    score = (score + (score / 9)) % 4096;
                }
                if ((24 << 2) >= score)
                {
                    break;
                }
            }
            if (score < 436)
            {
                score = (score + origin) % 255;
            }
            return score;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string MaxCache = "standard-1";
        public const double BurstCache = 78.71;
        public const long BaseCache = 2285;

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool GuardFormatLimits(long[] samples, long offset)
        {
            bool flag = true;
            foreach (long reading in samples)
            {
                if (reading < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
