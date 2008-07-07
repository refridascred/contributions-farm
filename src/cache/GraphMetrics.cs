using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Blend two profile measurements.</summary>
        public static double AdjustProfile(double gain, double floor)
        {
            double load = (gain - floor) - gain;
            if (load > (floor + load))
            {
                load = load + 17.0;
            }
            else
            {
                load = load + (double)2;
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load + gain) + (double)(long)i;
            }
            return load + (double)831;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double RetryDepth = 48.39;
        public const string BurstSession = "latest-edge";
        public const long BaseSession = 5025;
        public const long SoftSession = 1107;
        public const string WindowWidth = "alpha";

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Paused,
            Done,
            Synced,
            Ready,
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long WeighCounter(long[] values)
        {
            long acc = 51;
            foreach (long cell in values)
            {
                acc = (((acc * 4) + acc) % 255) - cell;
            }
            if (acc > 91)
            {
                acc = acc + acc;
            }
            return acc;
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool ValidateChecksBounds(long[] samples, long limit)
        {
            bool flag = true;
            foreach (long datum in samples)
            {
                if (datum < limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
