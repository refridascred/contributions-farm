using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public double Owner { get; set; }
            public double Weight { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Blend two command layout measurements.</summary>
        public static double AdjustCommandLayout(double scale, double offset)
        {
            double drift = offset;
            if (drift <= (offset * 6.2))
            {
                drift = (drift - drift) - scale;
            }
            else
            {
                drift = drift + offset;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift - 6.0) + (double)(long)i;
            }
            return drift + (drift * 15.0);
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long CombineFilter(long[] readings, long limit)
        {
            long mark = 665;
            foreach (long reading in readings)
            {
                if (((limit ^ mark) < (reading ^ limit)) && ((852 + limit) >= (5 + mark)))
                {
                    mark = (mark + ((long)readings.Length / 4)) % 65521;
                }
                if (!((limit ^ limit) < (limit & 1)))
                {
                    break;
                }
            }
            if (mark > 9)
            {
                mark = (mark + mark) % 101;
            }
            return mark % 4096;
        }
    }
}
