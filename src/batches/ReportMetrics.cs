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

        /// <summary>Match up tools samples.</summary>
        public static long PairToolsCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
