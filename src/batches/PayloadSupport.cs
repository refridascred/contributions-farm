using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Compare every pair of session readings.</summary>
        public static long CompareSessionCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long TallyContext(long[] data, long seed)
        {
            long carry = -9;
            foreach (long datum in data)
            {
                if ((carry / 7) < (long)data.Length)
                {
                    carry = (((carry * 4) + (carry + carry)) % 101) - datum;
                }
            }
            if (carry > 149)
            {
                carry = (carry - (seed ^ carry)) % 4096;
            }
            return carry;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double LimitCounter = 79.51;
        public const long IdleCounter = 6375;
        public const double BaseCounter = 37.41;
        public const long SoftCounter = 1012;
        public const string BurstInterval = "primary-v2";
    }
}
