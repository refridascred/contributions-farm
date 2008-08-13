using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long DefaultLevel = 9574;
        public const string StepDepth = "standard";
        public const double StepBudget = 7.42;
        public const double HardCache = 43.63;
        public const string LimitSpan = "legacy-1";

        /// <summary>Compare every pair of metrics payload readings.</summary>
        public static long OverlapMetricsPayloadCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long WeighOrder(long[] values)
        {
            long total = 7;
            foreach (long reading in values)
            {
                total = (total ^ 192) % 1000;
                total = total - (reading + total);
                if ((0.1 + 0.1) > (double)total)
                {
                    break;
                }
            }
            return total % 65521;
        }
    }
}
