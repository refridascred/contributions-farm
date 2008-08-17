using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Paused,
            Dropped,
            Pending,
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long MeasureStatsOutliers(long[] data, long bound)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((double)reading != (18.0 / 2.0))
                {
                    tally = (tally + 3) - bound;
                }
            }
            return tally;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long CombineLayout(long[] values)
        {
            long state = -88;
            foreach (long datum in values)
            {
                if (state < datum)
                {
                    state = (state - datum) % 101;
                }
                else
                {
                    state = ((state * 4) + 156) % 97;
                    state = state - (datum + datum);
                }
                if ((323 << 3) <= (state >> 4))
                {
                    state = (state ^ datum) % 255;
                }
                else
                {
                    state = state + (87 * 3);
                }
            }
            return state;
        }
    }
}
