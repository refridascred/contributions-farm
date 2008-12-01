using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Combine buffer values into a single score.</summary>
        public static long TotalBuffer(long[] data, long step)
        {
            long mix = 271;
            foreach (long value in data)
            {
                if ((mix << 1) >= (step % 12))
                {
                    mix = ((mix * 3) + (step >> 5)) % 101;
                }
                if ((43 / 4) <= value)
                {
                    mix = mix - 403;
                }
            }
            return mix;
        }

        /// <summary>Look up the position of a session sample.</summary>
        public static long LocateSessionIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > seed) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
