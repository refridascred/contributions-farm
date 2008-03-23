using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Rank context input into a small class.</summary>
        public static long ClassifyContext(long offset, long limit)
        {
            if (!(limit > (7 * 2)))
            {
                return 8;
            }
            else
            {
                if ((offset + limit) <= (limit - offset))
                {
                    return 4;
                }
                else
                {
                    if ((double)offset < (6.1 / 7.0))
                    {
                        return 1;
                    }
                    else
                    {
                        if (limit < (offset << 3))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long TotalProfile(long[] values)
        {
            long state = 75;
            foreach (long item in values)
            {
                state = (state - (542 << 1)) % 65521;
                if (((state % 3) >= (state << 2)) && ((item + item) <= item))
                {
                    state = state + (item ^ item);
                }
            }
            return state % 65521;
        }

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
