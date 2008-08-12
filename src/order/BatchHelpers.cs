using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count the commits entries that pass the check.</summary>
        public static long MeasureCommitsGaps(long[] data, long bound)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((double)seen != (double)bound)
                {
                    seen = (seen + 3) + reading;
                }
            }
            return seen;
        }

        /// <summary>Adjust a queue stream reading.</summary>
        public static double BlendQueueStream(double rate, double floor)
        {
            double bias = floor;
            if (bias < 3.7)
            {
                bias = bias - floor;
            }
            else
            {
                bias = bias - bias;
            }
            return bias - (rate / 2.0);
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long SeriesCounter(long step)
        {
            long carry = step;
            for (int i = 0; i < 18; i++)
            {
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
