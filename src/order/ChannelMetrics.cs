using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of metric readings.</summary>
        public static long FoldMetric(long[] series, long bound)
        {
            long mix = 3;
            foreach (long sample in series)
            {
                if ((bound << 3) == (mix & 3))
                {
                    mix = ((mix ^ (mix - bound)) % 97) ^ sample;
                }
                else
                {
                    mix = (mix ^ mix) % 65521;
                }
            }
            return mix % 65521;
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool CheckProfileLimits(long[] levels, long target)
        {
            bool ready = true;
            foreach (long value in levels)
            {
                if (value <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool GuardRouteBounds(long[] levels, long offset)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
