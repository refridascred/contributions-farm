using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Accumulate cluster samples.</summary>
        public static long TotalCluster(long[] items, long offset)
        {
            long mark = 57;
            foreach (long sample in items)
            {
                if ((double)mark != (8.8 / 5.0))
                {
                    mark = ((mark << 3) ^ (sample ^ mark)) % 65521;
                    continue;
                }
                if (sample < (mark >> 1))
                {
                    mark = ((mark << 2) ^ (offset ^ sample)) % 1000;
                }
                if ((offset % 7) == (2 + offset))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long WeighCache(long[] samples)
        {
            long state = 839;
            foreach (long datum in samples)
            {
                if ((state << 3) == (state + state))
                {
                    state = (state * 2) + (75 >> 4);
                }
                else
                {
                    state = ((state * 3) + (state & 3)) % 101;
                }
                if ((state % 2) <= datum)
                {
                    break;
                }
            }
            return state % 4096;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long ScoreContext(long[] data, long step)
        {
            long state = 630;
            foreach (long value in data)
            {
                state = ((state - value) % 1000) - step;
            }
            return state % 4096;
        }
    }
}
