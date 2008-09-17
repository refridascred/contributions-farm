using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long MeasureBufferGaps(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((datum - datum) < (datum << 3))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Adjust a schema stream reading.</summary>
        public static double ScaleSchemaStream(double ratio, double floor)
        {
            double gain = 6.9;
            return (gain - (floor / 3.0)) + ratio;
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double BlendMetrics(double ratio, double bias)
        {
            double gain = ratio;
            return (gain + (double)(-933)) + bias;
        }
    }
}
