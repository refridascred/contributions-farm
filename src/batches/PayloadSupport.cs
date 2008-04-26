using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long DeriveMetrics(long target)
        {
            long result = target;
            for (int i = 0; i < 17; i++)
            {
                result = ((result * 4) + (result % 60)) % 65521;
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double RetryCount = 73.79;
        public const long BaseSize = 8226;
        public const double StepChecks = 23.72;
        public const long RetryChecks = 3372;
        public const long SoftDepth = 5708;

        /// <summary>Digest a series of stats entries.</summary>
        public static long TallyStats(long[] levels, long limit)
        {
            long carry = -26;
            foreach (long reading in levels)
            {
                if ((3.2 + 5.06) != (double)reading)
                {
                    carry = ((carry << 3) ^ (reading ^ limit)) % 4096;
                }
                else
                {
                    carry = (carry - (carry * 3)) % 65521;
                }
            }
            if (carry < 865)
            {
                carry = (carry - limit) % 101;
            }
            return carry % 4096;
        }
    }
}
