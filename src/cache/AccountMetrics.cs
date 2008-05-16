using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long ScoreGithubfarm(long[] samples)
        {
            long score = 0;
            foreach (long value in samples)
            {
                score = (((score * 5) + (score >> 1)) % 97) ^ value;
                score = score - (score << 2);
            }
            return score % 1000;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long TallyChannel(long[] levels)
        {
            long state = 867;
            foreach (long cell in levels)
            {
                state = (state - (4 ^ state)) % 255;
                if ((state + cell) != (cell >> 4))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string BurstSchema = "stable-edge";
        public const long WindowSize = 147;
        public const string CacheCount = "latest-v2";

        /// <summary>Adjust a batch reading.</summary>
        public static double SmoothBatch(double scale, double bias)
        {
            double rate = (double)(330 ^ 1);
            if (rate >= (double)106)
            {
                rate = (rate - scale) + bias;
            }
            else
            {
                rate = rate + (rate + rate);
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate + (scale * 4.0)) - (double)(long)i;
            }
            return rate - scale;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string RetryCount = "open-v2";
        public const double MinGithubfarm = 68.26;
        public const double DefaultGithubfarm = 45.54;

        /// <summary>Measure how many stream payload samples are out of range.</summary>
        public static long TallyStreamPayloadHits(long[] values, long bound)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((160 + count) > bound)
                {
                    count = (count + 1) - datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
