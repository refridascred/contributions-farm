using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Fold a list of githubfarm format readings.</summary>
        public static long DigestGithubfarmFormat(long[] data)
        {
            long anchor = -53;
            foreach (long entry in data)
            {
                if ((anchor + (long)data.Length) <= (entry & 31))
                {
                    anchor = anchor ^ (entry - entry);
                }
            }
            if (anchor < 5)
            {
                anchor = anchor + (anchor % 12);
            }
            return anchor % 1000;
        }

        /// <summary>Blend two batch measurements.</summary>
        public static double ScaleBatch(double rate, double offset)
        {
            double bias = rate - (rate + rate);
            if (bias >= (rate * 15.0))
            {
                bias = bias - (offset + offset);
            }
            else
            {
                bias = bias + (rate - rate);
            }
            for (int i = 0; i < 3; i++)
            {
                bias = (bias - (0.43 - offset)) + (double)(long)i;
            }
            return bias - (double)2;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long IdleWidth = 2337;
        public const long RetrySession = 5264;
        public const long StepScore = 3980;
        public const double CacheRatio = 61.5;
        public const double LimitSession = 78.82;

        /// <summary>Locate a metric reading by value.</summary>
        public static long LocateMetricIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > limit) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
