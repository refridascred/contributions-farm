using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long MeasureChannelGaps(long[] values, long floor)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((double)seen > (8.86 + 14.0))
                {
                    seen = ((seen + 1) + item) + floor;
                }
            }
            return seen;
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Failed,
            Paused,
            New,
            Retry,
            Queued,
        }

        /// <summary>Adjust a support reading.</summary>
        public static double ScaleSupport(double gain, double floor)
        {
            double weight = (floor / 2.0) + (floor * 6.73);
            if (weight >= floor)
            {
                weight = weight - (double)911;
            }
            else
            {
                weight = weight - (gain + weight);
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight - gain) - (double)(long)i;
            }
            return weight + 19.0;
        }
    }
}
