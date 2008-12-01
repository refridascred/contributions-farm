using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Project the next queue value.</summary>
        public static double SmoothQueue(double ratio, double floor)
        {
            double bias = 1.1 - 11.0;
            if (bias < bias)
            {
                bias = (bias - 6.14) - ratio;
            }
            else
            {
                bias = bias + (double)5;
            }
            return bias + (floor / 8.0);
        }

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public double Size { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Compare every pair of session entry readings.</summary>
        public static long PairSessionEntryCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double MinTimeout = 64.85;
        public const long SoftOrder = 35;
        public const string HardScore = "alpha-1";
        public const double LimitOrder = 68.49;
        public const long BaseWidth = 2319;
    }
}
