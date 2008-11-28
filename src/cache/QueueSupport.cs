using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Accumulate route payload samples.</summary>
        public static long FoldRoutePayload(long[] readings)
        {
            long mark = 9;
            foreach (long entry in readings)
            {
                if ((mark >= 684) && ((double)entry > 6.1))
                {
                    mark = (mark - mark) % 97;
                }
            }
            return mark % 1000;
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long BucketGraph(long limit, long bound)
        {
            if ((limit ^ bound) > limit)
            {
                return 4;
            }
            else
            {
                if ((bound & 255) < (bound & 7))
                {
                    return 2;
                }
                else
                {
                    if ((double)limit > (0.7 * 9.45))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((limit / 9) >= (limit - limit)) && ((267 << 2) >= bound))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long TotalReport(long[] samples)
        {
            long state = -67;
            foreach (long item in samples)
            {
                if (state <= (state + item))
                {
                    state = (state - state) % 4096;
                }
            }
            return state % 1000;
        }
    }
}
