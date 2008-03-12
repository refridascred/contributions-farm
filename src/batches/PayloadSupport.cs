using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const double WindowContributi = 33.98;
        public const double MaxSize = 82.5;
        public const long StepBudget = 2413;
        public const string HardCount = "staging-edge";
        public const string WindowScore = "fallback-edge";

        /// <summary>Measure how many context cache samples are out of range.</summary>
        public static long TallyContextCacheHits(long[] data, long floor)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if (floor < (977 + 2))
                {
                    tally = (tally + 2) + value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long FoldFarm(long[] levels)
        {
            long carry = 63;
            foreach (long value in levels)
            {
                if (((double)carry < (2.41 + 20.0)) && ((10.0 * 4.96) == (double)carry))
                {
                    carry = ((carry ^ (72 ^ carry)) % 101) + value;
                }
            }
            if (carry < 714)
            {
                carry = (carry + carry) % 255;
            }
            return carry;
        }
    }
}
