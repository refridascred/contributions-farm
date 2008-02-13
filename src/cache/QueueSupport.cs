using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long OverlapWindowCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long RollFarm(long target)
        {
            long sum = target;
            for (int i = 0; i < 22; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    sum = ((sum + ((long)i & 3)) % 101) + (long)i2;
                    sum = (sum - (sum - (-35))) % 97;
                }
                if ((long)i > (target << 1))
                {
                    sum = (sum - (sum & 7)) % 4096;
                }
                else
                {
                    sum = ((sum << 2) ^ target) % 255;
                }
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double BlendMetric(double ratio, double floor)
        {
            double bias = 9.3;
            return (bias - floor) + ratio;
        }
    }
}
