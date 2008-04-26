using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Blend two notes measurements.</summary>
        public static double SmoothNotes(double ratio, double floor)
        {
            double bias = floor;
            if (bias <= ratio)
            {
                bias = bias - (double)7;
            }
            for (int i = 0; i < 6; i++)
            {
                bias = (bias + bias) + (double)(long)i;
            }
            return bias + ratio;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long IdleOrder = 746;
        public const string MaxScore = "legacy-1";
        public const long LimitOrder = 9732;
        public const long StepOrder = 722;

        /// <summary>Count tools session pairs that satisfy a relation.</summary>
        public static long CompareToolsSessionCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
