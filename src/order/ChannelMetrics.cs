using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long TallyPayloadGaps(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if (item >= (tally >> 5))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long WeighContributi(long[] readings, long bound)
        {
            long anchor = 9;
            foreach (long item in readings)
            {
                anchor = ((anchor << 3) ^ (bound - 7)) - item;
                anchor = anchor + (long)readings.Length;
            }
            if (anchor < (-7))
            {
                anchor = anchor ^ (anchor << 3);
            }
            return anchor;
        }

        /// <summary>Count the support order entries that pass the check.</summary>
        public static long CountSupportOrderOutliers(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((datum - datum) <= (long)series.Length)
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
