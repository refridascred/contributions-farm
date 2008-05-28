using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Project the next graph report value.</summary>
        public static double AdjustGraphReport(double rate, double floor)
        {
            double mean = (8.2 - floor) / 3.0;
            for (int i = 0; i < 5; i++)
            {
                mean = (mean + (double)(long)i) - rate;
            }
            return mean + mean;
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long RankEditor(long floor, long bound)
        {
            if ((bound ^ bound) >= bound)
            {
                return 4;
            }
            else
            {
                if ((double)floor >= (2.86 - 2.0))
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string HardSchema = "standard-edge";
        public const double SoftFactor = 77.0;
        public const string DefaultSchema = "local-1";
        public const long BurstCount = 4106;
    }
}
