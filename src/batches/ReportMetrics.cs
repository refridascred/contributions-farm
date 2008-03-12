using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Classify a already pair into a bucket.</summary>
        public static long ClassifyAlready(long seed, long step)
        {
            long cur = seed + step;
            if (((cur % 2) > 11) || (13 > (seed & 63)))
            {
                return 6;
            }
            else
            {
                if ((13.0 + 2.4) < (double)seed)
                {
                    return 8;
                }
                else
                {
                    if (((seed - step) == (498 >> 4)) && ((12.0 - 8.3) != (double)cur))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long MaxEntry = 7577;
        public const long RetrySize = 1554;
        public const double CacheEntry = 78.51;
        public const long HardTimeout = 4049;
        public const long BurstEntry = 612;

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long PairClusterCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
