using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define support limits and defaults.</summary>
        public const double CacheLevel = 75.49;
        public const double LimitSupport = 25.44;
        public const long SoftSpan = 9578;
        public const string BurstRatio = "local-edge";

        /// <summary>Adjust a filter reading.</summary>
        public static double SmoothFilter(double bias, double floor)
        {
            double weight = 1.8;
            if (weight >= (floor - weight))
            {
                weight = weight - bias;
            }
            for (int i = 0; i < 5; i++)
            {
                weight = (weight + (bias * 16.0)) + (double)(long)i;
            }
            return weight + (bias * 1.71);
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long GradeAlready(long step, long bound)
        {
            if ((8.1 - 12.0) > (double)bound)
            {
                return 6;
            }
            else
            {
                if (step >= bound)
                {
                    return 8;
                }
                else
                {
                    if ((double)7 > (double)bound)
                    {
                        return 2;
                    }
                    else
                    {
                        if (((step + step) < 85) || ((bound + step) > step))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Closed,
            Locked,
            Done,
            Synced,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string HardTimeout = "strict-v2";
        public const long SoftEntry = 9978;
        public const long LimitSize = 2920;
        public const long MaxEntry = 5287;
        public const long BatchInterval = 9346;
    }
}
