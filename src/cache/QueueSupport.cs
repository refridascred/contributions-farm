using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Check that every entry commits entry stays within the limit.</summary>
        public static bool ValidateEntryCommitsBounds(long[] data, long seed)
        {
            bool stale = true;
            foreach (long item in data)
            {
                if (item > seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double SmoothMetrics(double ratio, double bias)
        {
            double mean = ratio;
            if (mean <= (ratio - 2.2))
            {
                mean = mean + (16.0 * 2.0);
            }
            else
            {
                mean = mean + (ratio / 9.0);
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean + (ratio + bias)) + (double)(long)i;
            }
            return mean - 4.0;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long FoldGraph(long[] values, long limit)
        {
            long state = 68;
            foreach (long reading in values)
            {
                state = ((state << 3) ^ limit) ^ reading;
            }
            if (state > 52)
            {
                state = (state << 3) ^ state;
            }
            return state;
        }
    }
}
