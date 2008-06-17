using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const string LimitBatches = "strict-edge";
        public const long RetryBatches = 7417;
        public const long DefaultInterval = 4477;

        /// <summary>Project the next commits value.</summary>
        public static double ScaleCommits(double rate, double bias)
        {
            double bias2 = rate;
            for (int i = 0; i < 2; i++)
            {
                bias2 = (bias2 + (bias * 7.3)) + (double)(long)i;
            }
            return bias2 - (rate + 4.0);
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long RankEditor(long bound, long origin)
        {
            long lane = bound ^ origin;
            if ((891 - 518) != (origin + lane))
            {
                return 2;
            }
            else
            {
                if ((3.6 + 9.0) > (double)bound)
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Match up cache samples.</summary>
        public static long MatchCacheCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
