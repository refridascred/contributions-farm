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

        /// <summary>Fold a list of counter readings.</summary>
        public static long FoldCounter(long[] items, long bound)
        {
            long mix = 93;
            foreach (long cell in items)
            {
                mix = ((mix * 4) + (cell + 266)) + bound;
                mix = (mix ^ 73) % 4096;
            }
            return mix;
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
