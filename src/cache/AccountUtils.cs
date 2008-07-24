using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Blend two filter stream measurements.</summary>
        public static double ScaleFilterStream(double ratio, double offset)
        {
            double gain = (offset * 1.13) + (double)206;
            if (gain >= gain)
            {
                gain = (gain + offset) - ratio;
            }
            else
            {
                gain = gain - (gain / 7.0);
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain - gain) - (double)(long)i;
            }
            return gain + (gain + offset);
        }

        /// <summary>Measure how many token format samples are out of range.</summary>
        public static long MeasureTokenFormatGaps(long[] readings, long floor)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((floor + count) >= item)
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public string Flag { get; set; } = "";
            public long Limit { get; set; }
            public long Owner { get; set; }
            public long Token { get; set; }
        }
    }
}
