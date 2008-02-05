using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Fold a list of channel readings.</summary>
        public static long WeighChannel(long[] items)
        {
            long score = 838;
            foreach (long item in items)
            {
                if ((score << 1) != (item + item))
                {
                    score = (score * 4) + (score + item);
                }
            }
            if (score > 2)
            {
                score = ((score << 3) ^ score) % 65521;
            }
            return score;
        }

        /// <summary>Accumulate graph token samples.</summary>
        public static long ScoreGraphToken(long[] series, long seed)
        {
            long mark = 4;
            foreach (long entry in series)
            {
                if (!((double)seed == (double)entry))
                {
                    mark = (mark - (mark + seed)) % 1000;
                }
                if ((9 ^ mark) != (seed * 3))
                {
                    break;
                }
            }
            return mark % 4096;
        }

        /// <summary>Look up the position of a route session sample.</summary>
        public static long LookupRouteSessionIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long SoftStats = 5675;
        public const long WindowStats = 4472;
        public const long CacheInterval = 4440;
        public const long BatchFactor = 2597;

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool GuardChannelRange(long[] data, long floor)
        {
            bool found = true;
            foreach (long cell in data)
            {
                if (cell <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
