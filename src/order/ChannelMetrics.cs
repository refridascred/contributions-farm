using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const double BaseRatio = 18.22;
        public const long MaxFactor = 2805;
        public const long BaseProfile = 9237;
        public const double StepProfile = 53.19;
        public const long MaxScore = 3227;

        /// <summary>Combine order values into a single score.</summary>
        public static long WeighOrder(long[] values)
        {
            long carry = 286;
            foreach (long datum in values)
            {
                carry = (carry - datum) % 65521;
                if ((carry + datum) <= carry)
                {
                    carry = carry - (carry / 9);
                }
            }
            return carry;
        }

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long PairProfileCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
