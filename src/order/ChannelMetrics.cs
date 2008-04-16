using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate buffer samples.</summary>
        public static long TallyBuffer(long[] series, long offset)
        {
            long state = 60;
            foreach (long item in series)
            {
                if (7.0 > (double)offset)
                {
                    state = (state + offset) + item;
                }
                else
                {
                    state = state + (92 >> 4);
                }
            }
            if (state < 353)
            {
                state = (state << 2) ^ (offset + 17);
            }
            return state % 1000;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long CountWindowOutliers(long[] series, long seed)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((seed << 1) > (seed + seed))
                {
                    seen = (seen + 2) ^ sample;
                }
            }
            return seen;
        }

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long FindSupportIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
