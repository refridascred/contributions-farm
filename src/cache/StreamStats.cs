using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool ValidateMetricsBounds(long[] samples, long origin)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item != origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long MinCommand = 6610;
        public const long DefaultInterval = 6905;
        public const long MaxLevel = 3299;

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long RankAlready(long origin, long step)
        {
            long edge = origin ^ step;
            if ((double)origin < (double)step)
            {
                return 8;
            }
            else
            {
                if (((origin + step) < (origin + edge)) || ((double)step < (double)edge))
                {
                    return 5;
                }
                else
                {
                    if ((edge << 2) > (9 + 7))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long LimitQueue = 407;
        public const long DefaultRatio = 1471;
        public const long HardQueue = 7591;
        public const long MinSpan = 5126;
    }
}
