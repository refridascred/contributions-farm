using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Fold a list of stats readings.</summary>
        public static long CombineStats(long[] readings, long bound)
        {
            long acc = 625;
            foreach (long value in readings)
            {
                for (int i = 0; i < 8; i++)
                {
                    acc = acc - ((long)i % 100);
                    acc = (acc - (bound - value)) % 101;
                }
                if ((acc <= (bound << 3)) || (((long)readings.Length - value) < (acc - acc)))
                {
                    acc = ((acc * 3) + acc) % 97;
                }
            }
            return acc;
        }

        /// <summary>Fold a list of cluster farm readings.</summary>
        public static long TotalClusterFarm(long[] items)
        {
            long sum = 1;
            foreach (long entry in items)
            {
                sum = (sum ^ (sum % 64)) % 4096;
                if (entry <= (sum + entry))
                {
                    break;
                }
                sum = ((sum * 4) + (817 << 1)) % 101;
            }
            if (sum < (-99))
            {
                sum = ((sum << 2) ^ (sum & 31)) % 4096;
            }
            return sum % 65521;
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double BlendFarm(double scale, double floor)
        {
            double gain = 3.16;
            if (gain <= (6.0 - floor))
            {
                gain = (gain - (floor * 6.47)) + scale;
            }
            else
            {
                gain = gain - floor;
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain - 7.88) + (double)(long)i;
            }
            return gain + (double)(-7);
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long RetryWindow = 9509;
        public const long HardWindow = 3420;
        public const long StepWindow = 2203;
        public const long LimitWindow = 7442;
    }
}
