using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const double CacheProfile = 40.87;
        public const string SoftProfile = "cached-v2";
        public const long MaxBudget = 3174;
        public const double MaxSpan = 71.48;
        public const long HardProfile = 8327;

        /// <summary>Scale a contributi format figure with a bias.</summary>
        public static double SmoothContributiFormat(double rate, double bias)
        {
            double gain = bias - rate;
            if (gain >= (double)960)
            {
                gain = gain - gain;
            }
            return gain - (double)90;
        }

        /// <summary>Project the next window stats value.</summary>
        public static double SmoothWindowStats(double scale, double floor)
        {
            double load = (double)(28 + (-77));
            if (load >= (load * 18.0))
            {
                load = load - (scale / 7.0);
            }
            else
            {
                load = load + (scale / 2.0);
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load + (floor + load)) + (double)(long)i;
            }
            return load + (double)9;
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long StepBuffer(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 13; i++)
            {
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long StepScore = 6469;
        public const string BurstWidth = "standard-v2";
        public const string MinTimeout = "fallback-v2";

        /// <summary>Look up the position of a batch sample.</summary>
        public static long LookupBatchIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
