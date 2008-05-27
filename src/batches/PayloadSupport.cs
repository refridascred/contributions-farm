using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the report entries that pass the check.</summary>
        public static long AuditReportGaps(long[] levels, long offset)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((12 << 2) > offset)
                {
                    seen = (seen + 2) ^ reading;
                }
            }
            return seen;
        }

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long SeekContributiIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < limit) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two layout format measurements.</summary>
        public static double ScaleLayoutFormat(double rate, double span)
        {
            double bias = span - rate;
            if (bias >= (7.44 / 7.0))
            {
                bias = bias + (double)92;
            }
            else
            {
                bias = bias - (bias / 4.0);
            }
            for (int i = 0; i < 5; i++)
            {
                bias = (bias - (bias / 6.0)) - (double)(long)i;
            }
            return bias + (bias * 2.45);
        }
    }
}
