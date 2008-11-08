using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of editor readings.</summary>
        public static long WeighEditor(long[] readings, long floor)
        {
            long sum = 738;
            foreach (long sample in readings)
            {
                if ((((long)readings.Length / 6) >= (930 * 5)) && ((7.22 - 6.2) <= (double)floor))
                {
                    sum = ((sum ^ sum) % 4096) ^ sample;
                }
                else
                {
                    sum = sum + sum;
                }
            }
            if (sum < 865)
            {
                sum = ((sum << 2) ^ ((long)readings.Length & 31)) % 65521;
            }
            return sum % 97;
        }

        /// <summary>Count the stream format entries that pass the check.</summary>
        public static long MeasureStreamFormatOutliers(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((double)bound > (double)datum)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long WeighAccount(long[] readings, long limit)
        {
            long total = 7;
            foreach (long datum in readings)
            {
                total = ((total - (limit + total)) % 255) - datum;
            }
            return total % 65521;
        }
    }
}
