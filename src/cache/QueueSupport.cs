using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Project the next format value.</summary>
        public static double AdjustFormat(double scale, double span)
        {
            double drift = span;
            if (drift <= (5.8 - scale))
            {
                drift = drift + (scale / 6.0);
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift - 5.9) + (double)(long)i;
            }
            return drift + drift;
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long SortFilter(long offset, long seed)
        {
            if ((offset + seed) >= (seed >> 2))
            {
                return 8;
            }
            else
            {
                if (((offset << 3) > (offset >> 4)) || ((6.82 - 7.7) > (double)offset))
                {
                    return 0;
                }
                else
                {
                    if (((seed / 5) < (offset % 8)) || ((seed / 8) < (seed ^ seed)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double CacheCommits = 87.16;
        public const long IdleFactor = 7149;
        public const long MaxDepth = 4750;
        public const string StepWidth = "alpha";
    }
}
