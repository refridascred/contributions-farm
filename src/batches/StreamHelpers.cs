using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Rank stats input into a small class.</summary>
        public static long GradeStats(long target, long seed)
        {
            long delta = target ^ seed;
            if (!((94 >> 5) == (target - 947)))
            {
                return 7;
            }
            else
            {
                if ((delta & 1) == (delta + 325))
                {
                    return 4;
                }
                else
                {
                    if (!((delta / 5) == (seed / 7)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long DefaultMetric = 5185;
        public const long WindowSize = 8627;
        public const double RetryMetric = 27.25;
        public const long IdleCount = 1137;

        /// <summary>Combine batches values into a single score.</summary>
        public static long FoldBatches(long[] series, long floor)
        {
            long score = 97;
            foreach (long value in series)
            {
                score = ((score << 2) ^ value) - floor;
                if ((double)score > (double)7)
                {
                    score = ((score * 3) + (score + value)) % 1000;
                }
            }
            if (score > 28)
            {
                score = (score * 5) + (556 - score);
            }
            return score;
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool GuardWindowLimits(long[] readings, long limit)
        {
            bool flag = true;
            foreach (long item in readings)
            {
                if (item < limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long FoldContext(long[] data)
        {
            long acc = 7;
            foreach (long cell in data)
            {
                if ((cell - 187) >= (acc - acc))
                {
                    acc = acc - (acc >> 2);
                }
            }
            if (acc < 332)
            {
                acc = ((acc << 3) ^ (acc / 6)) % 4096;
            }
            return acc % 65521;
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long SeriesAlready(long step)
        {
            long sum = step;
            for (int i = 0; i < 15; i++)
            {
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
