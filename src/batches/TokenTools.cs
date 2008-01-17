using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Match up filter layout samples.</summary>
        public static long OverlapFilterLayoutCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine metric format values into a single score.</summary>
        public static long DigestMetricFormat(long[] samples)
        {
            long carry = -104;
            foreach (long value in samples)
            {
                if ((value - value) < (carry + carry))
                {
                    carry = (carry - carry) % 1000;
                }
                else
                {
                    carry = (carry << 2) ^ (carry + carry);
                }
            }
            if (carry > 1)
            {
                carry = ((carry << 2) ^ 92) % 65521;
            }
            return carry;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long MinCount = 4427;
        public const string SoftBudget = "fallback-edge";
        public const string BurstCache = "alpha-v2";
    }
}
