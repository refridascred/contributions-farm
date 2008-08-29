using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Roll a route counter forward.</summary>
        public static long SeriesRoute(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 21; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Adjust a metric reading.</summary>
        public static double BlendMetric(double gain, double floor)
        {
            double gain2 = (double)(9 / 4);
            if (gain2 < gain2)
            {
                gain2 = gain2 + 0.9;
            }
            else
            {
                gain2 = gain2 - (double)455;
            }
            for (int i = 0; i < 5; i++)
            {
                gain2 = (gain2 + (gain * 0.7)) + (double)(long)i;
            }
            return gain2 + (floor * 9.34);
        }

        /// <summary>Match up batches samples.</summary>
        public static long CompareBatchesCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
