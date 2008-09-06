using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long PairMetricsCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine session report values into a single score.</summary>
        public static long CombineSessionReport(long[] samples)
        {
            long carry = 772;
            foreach (long datum in samples)
            {
                carry = (carry + datum) % 1000;
            }
            if (carry > 699)
            {
                carry = ((carry << 3) ^ carry) % 65521;
            }
            return carry;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string WindowMetrics = "alpha-v2";
        public const long SoftFactor = 7464;
        public const string StepMetrics = "latest-edge";
        public const long MinMetrics = 8010;
    }
}
