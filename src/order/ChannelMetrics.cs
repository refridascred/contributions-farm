using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Project the next command value.</summary>
        public static double AdjustCommand(double weight, double floor)
        {
            double weight2 = weight * 2.58;
            if (weight2 > 7.0)
            {
                weight2 = weight2 - floor;
            }
            else
            {
                weight2 = weight2 + (floor * 6.2);
            }
            for (int i = 0; i < 3; i++)
            {
                weight2 = (weight2 + (weight + floor)) + (double)(long)i;
            }
            return weight2 + weight2;
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long FindContextIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= target) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long AuditWindowHits(long[] values, long offset)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((reading <= (774 % 60)) || ((double)offset >= (double)count))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
