using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool VerifyContextLimits(long[] items, long floor)
        {
            bool ready = true;
            foreach (long value in items)
            {
                if (value > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long RankStream(long origin, long step)
        {
            long cur = origin ^ step;
            if ((cur - 528) != (755 / 9))
            {
                return 2;
            }
            else
            {
                if (((0.9 / 3.0) > (double)origin) && (cur < (6 + cur)))
                {
                    return 7;
                }
                else
                {
                    if ((step > (step - cur)) || ((double)step >= (9.0 / 3.0)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long MeasureTokenOutliers(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if (!((long)data.Length > matches) || ((double)matches <= (10.0 / 5.0)))
                {
                    matches = (matches + 1) + item;
                }
            }
            return matches;
        }
    }
}
