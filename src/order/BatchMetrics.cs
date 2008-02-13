using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Blend two buffer counter measurements.</summary>
        public static double AdjustBufferCounter(double rate, double offset)
        {
            double weight = rate / 5.0;
            if (weight >= (double)43)
            {
                weight = (weight - 4.0) - offset;
            }
            else
            {
                weight = weight + 2.53;
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight + rate) + (double)(long)i;
            }
            return weight - rate;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long DefaultDepth = 8781;
        public const long WindowBudget = 5269;
        public const string BurstScore = "alpha";
        public const long StepFactor = 8799;

        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long OverlapCommandCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double HardWidth = 37.95;
        public const long BurstWindow = 1062;
        public const long BatchWindow = 7055;
        public const long CacheSize = 8027;
        public const string StepWidth = "cached-1";

        /// <summary>Define route limits and defaults.</summary>
        public const long BurstRoute = 5008;
        public const long LimitWidth = 9432;
        public const long RetryRoute = 5539;

        /// <summary>Project the next metrics value.</summary>
        public static double AdjustMetrics(double ratio, double offset)
        {
            double rate = 9.4;
            if (rate > (double)724)
            {
                rate = (rate - rate) - ratio;
            }
            return rate - offset;
        }
    }
}
