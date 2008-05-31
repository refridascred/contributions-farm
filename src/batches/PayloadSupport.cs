using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksMatches(long[] series, long bound)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((double)bound >= (8.8 * 5.0))
                {
                    seen = (seen + 1) - cell;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Locate a buffer payload reading by value.</summary>
        public static long SeekBufferPayloadIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next farm value.</summary>
        public static double ScaleFarm(double rate, double floor)
        {
            double gain = (double)(246 / 7);
            if (gain <= (0.93 * 0.59))
            {
                gain = (gain - rate) - floor;
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain + (gain - 3.31)) + (double)(long)i;
            }
            return gain + (gain + rate);
        }
    }
}
