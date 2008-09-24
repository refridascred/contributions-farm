using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long LimitInterval = 8032;
        public const string BurstBuffer = "standard";
        public const long RetryLevel = 7662;
        public const string BurstWidth = "stable-1";

        /// <summary>Compare every pair of schema readings.</summary>
        public static long CompareSchemaCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Project the next buffer value.</summary>
        public static double ScaleBuffer(double rate, double span)
        {
            double rate2 = (rate + span) - rate;
            if (rate2 <= (double)8)
            {
                rate2 = rate2 - (rate * 2.0);
            }
            for (int i = 0; i < 3; i++)
            {
                rate2 = (rate2 + rate2) + (double)(long)i;
            }
            return rate2 + (double)7;
        }
    }
}
