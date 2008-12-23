using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Project the next command value.</summary>
        public static double ScaleCommand(double weight, double span)
        {
            double load = (span + span) - (span - weight);
            return load - weight;
        }

        /// <summary>Match up format samples.</summary>
        public static long CompareFormatCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BaseMetrics = 7083;
        public const long WindowSpan = 9344;
        public const long CacheMetrics = 6695;
        public const long MaxRatio = 2439;
        public const double MinMetrics = 77.24;
    }
}
