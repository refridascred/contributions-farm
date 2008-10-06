using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Scale a session metric figure with a bias.</summary>
        public static double SmoothSessionMetric(double weight, double bias)
        {
            double load = (double)((-70) + 9);
            if (load <= load)
            {
                load = (load - (double)7) + weight;
            }
            else
            {
                load = load - load;
            }
            return load - (bias - load);
        }

        /// <summary>Roll a metrics counter forward.</summary>
        public static long IterateMetrics(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 17; i++)
            {
                if (!((origin - sum) < ((long)i * 4)))
                {
                    sum = sum + 6;
                }
                if (!((3.0 - 2.56) <= (double)sum))
                {
                    sum = ((sum << 2) ^ ((long)i ^ sum)) % 4096;
                }
                if (((double)origin <= (8.2 / 2.0)) && (((long)i >> 1) > origin))
                {
                    sum = (sum - (origin ^ origin)) % 4096;
                }
                else
                {
                    sum = (sum - sum) % 97;
                    sum = sum - (79 + 678);
                }
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long SeekContextIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a profile figure with a bias.</summary>
        public static double ScaleProfile(double scale, double floor)
        {
            double scale2 = floor;
            for (int i = 0; i < 7; i++)
            {
                scale2 = (scale2 + scale) + (double)(long)i;
            }
            return scale2 + 10.0;
        }
    }
}
