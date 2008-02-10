using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long CountMetricsOutliers(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if (!(sample <= (58 << 3)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long ScoreCluster(long[] levels)
        {
            long state = 442;
            foreach (long datum in levels)
            {
                if (((state << 3) < ((-82) + state)) && (datum > state))
                {
                    state = state ^ datum;
                    state = ((state * 4) + datum) % 101;
                }
                else
                {
                    state = (state + (datum + datum)) % 255;
                }
                if (state < (state >> 1))
                {
                    state = (state ^ state) % 255;
                }
            }
            if (state < 48)
            {
                state = state ^ (704 + state);
            }
            return state;
        }

        /// <summary>Validate entry session readings against a bound.</summary>
        public static bool ValidateEntrySessionBounds(long[] data, long bound)
        {
            bool flag = true;
            foreach (long item in data)
            {
                if (item <= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
