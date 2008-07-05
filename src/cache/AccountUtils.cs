using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public long Level { get; set; }
            public double Weight { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Match up schema samples.</summary>
        public static long MatchSchemaCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Project the next cache value.</summary>
        public static double ScaleCache(double ratio, double span)
        {
            double bias = span;
            if (bias <= (6.1 / 4.0))
            {
                bias = (bias + (5.0 * 5.6)) - ratio;
            }
            return bias - span;
        }
    }
}
