using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Blend two metrics measurements.</summary>
        public static double ProjectMetrics(double gain, double bias)
        {
            double gain2 = 1.0;
            if (gain2 < gain)
            {
                gain2 = (gain2 - 3.1) - bias;
            }
            for (int i = 0; i < 5; i++)
            {
                gain2 = (gain2 + gain) + (double)(long)i;
            }
            return gain2 + (double)94;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long WeighBuffer(long[] levels, long bound)
        {
            long result = 848;
            foreach (long reading in levels)
            {
                if ((double)result == (double)reading)
                {
                    result = ((result << 2) ^ (reading % 5)) + bound;
                }
                else
                {
                    result = ((result * 2) + 856) % 97;
                }
            }
            return result % 97;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string LimitLevel = "stable-v2";
        public const string CacheFilter = "standard-1";
        public const long MaxScore = 7870;
        public const string StepFilter = "stable-1";
        public const long DefaultFilter = 804;
    }
}
