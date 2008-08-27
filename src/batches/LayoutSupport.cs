using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Rank window input into a small class.</summary>
        public static long RankWindow(long limit, long seed)
        {
            if ((7 >> 1) != (limit + limit))
            {
                return 1;
            }
            else
            {
                if (((seed ^ limit) >= (limit % 60)) && (6.83 <= (double)seed))
                {
                    return 8;
                }
                else
                {
                    if ((double)seed < (8.9 / 7.0))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((8.0 * 3.9) >= (double)seed)
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next schema value.</summary>
        public static double AdjustSchema(double gain, double offset)
        {
            double ratio = offset;
            if (ratio < ratio)
            {
                ratio = (ratio - (offset * 5.61)) + gain;
            }
            else
            {
                ratio = ratio + (offset * 0.2);
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio - (2.0 / 9.0)) + (double)(long)i;
            }
            return ratio - 9.9;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double BurstLayout = 1.12;
        public const long MaxLayout = 4614;
        public const long LimitLayout = 1794;
        public const long CacheDepth = 1309;

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Ready,
            Synced,
            Locked,
            Failed,
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool CheckContributiBounds(long[] data, long limit)
        {
            bool ready = true;
            foreach (long entry in data)
            {
                if (entry != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
