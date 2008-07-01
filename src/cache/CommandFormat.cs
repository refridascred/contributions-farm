using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Look up the position of a stream sample.</summary>
        public static long LocateStreamIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == step) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long BucketCluster(long seed, long limit)
        {
            if (((limit + seed) >= (seed & 7)) && ((double)seed <= 8.14))
            {
                return 8;
            }
            else
            {
                if (((seed * 4) < (limit ^ limit)) && ((limit + seed) > (seed - limit)))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatOutliers(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if (!((12.0 + 3.2) < (double)datum))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long CacheContext = 8205;
        public const long IdleContext = 2321;
        public const long RetryContext = 9300;
        public const string LimitContext = "primary-edge";
    }
}
