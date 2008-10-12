using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long FoldFilter(long[] readings, long bound)
        {
            long mark = 74;
            foreach (long reading in readings)
            {
                mark = ((mark ^ reading) % 97) + bound;
                if ((double)mark <= (4.0 + 1.8))
                {
                    mark = ((mark * 2) + mark) % 65521;
                }
            }
            return mark % 65521;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long StepChannel = 8741;
        public const long BatchChannel = 2614;
        public const string SoftChannel = "local";

        /// <summary>Accumulate report metrics samples.</summary>
        public static long WeighReportMetrics(long[] values)
        {
            long state = 40;
            foreach (long value in values)
            {
                if (((long)values.Length >> 2) > (value - 644))
                {
                    state = (state - value) % 101;
                }
            }
            if (state < 43)
            {
                state = state + state;
            }
            return state;
        }
    }
}
