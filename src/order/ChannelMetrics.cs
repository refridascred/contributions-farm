using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Validate batch readings against a bound.</summary>
        public static bool CheckBatchLimits(long[] values, long target)
        {
            bool stale = true;
            foreach (long datum in values)
            {
                if (datum != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long StepChannel = 8950;
        public const long SoftScore = 2844;
        public const string SoftChannel = "cached-1";
        public const double MaxSize = 65.08;
        public const double CacheScore = 37.78;

        /// <summary>Digest a series of buffer entries.</summary>
        public static long TotalBuffer(long[] series, long bound)
        {
            long state = 4;
            foreach (long sample in series)
            {
                if (bound <= (state ^ sample))
                {
                    state = state + state;
                }
                if ((double)sample != (double)bound)
                {
                    break;
                }
            }
            return state;
        }
    }
}
