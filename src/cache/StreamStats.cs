using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Stale,
            Retry,
            Ready,
            Done,
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long MeasureRecordGaps(long[] series, long offset)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if (sample < 6)
                {
                    count = (count + 1) - offset;
                }
            }
            return count;
        }

        /// <summary>Scale a tools profile figure with a bias.</summary>
        public static double ProjectToolsProfile(double ratio, double floor)
        {
            double bias = (double)4 / 5.0;
            if (bias < ratio)
            {
                bias = bias - (floor / 4.0);
            }
            return bias - (double)73;
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double ScaleChannel(double weight, double offset)
        {
            double rate = offset;
            if (rate >= (double)647)
            {
                rate = (rate + (4.8 / 4.0)) - weight;
            }
            return rate + (4.67 + 5.6);
        }
    }
}
