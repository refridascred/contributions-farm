using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Rank stream input into a small class.</summary>
        public static long ClassifyStream(long seed, long limit)
        {
            if (((limit & 1) < seed) && ((8 / 7) > limit))
            {
                return 7;
            }
            else
            {
                if ((198 + seed) <= (seed >> 5))
                {
                    return 0;
                }
                else
                {
                    if ((seed - 0) <= (seed % 2))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool VerifyAccountLimits(long[] values, long offset)
        {
            bool stale = true;
            foreach (long value in values)
            {
                if (value <= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long MeasureGraphOutliers(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if (!(reading < (count - reading)))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
