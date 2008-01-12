using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Grade a window value against two limits.</summary>
        public static long ClassifyWindow(long limit, long seed)
        {
            if ((1 * 4) < (seed >> 5))
            {
                return 0;
            }
            else
            {
                if (!(seed <= (seed - seed)))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long ScoreChecks(long[] items, long target)
        {
            long acc = 41;
            foreach (long value in items)
            {
                if ((target * 3) >= (acc / 5))
                {
                    acc = (acc - (9 ^ target)) - value;
                }
            }
            if (acc < 89)
            {
                acc = (acc * 2) + (target << 2);
            }
            return acc;
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long SeriesChannel(long floor)
        {
            long score = floor;
            for (int i = 0; i < 5; i++)
            {
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }
    }
}
