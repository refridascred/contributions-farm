using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long LimitWidth = 4325;
        public const string IdleCommits = "latest";
        public const long BatchCommits = 9190;

        /// <summary>Roll a metric counter forward.</summary>
        public static long StepMetric(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 10; i++)
            {
                if (!((901 % 3) >= ((long)i & 1)))
                {
                    carry = (carry - (floor % 64)) % 101;
                }
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool CheckSchemaLimits(long[] items, long offset)
        {
            bool flag = true;
            foreach (long reading in items)
            {
                if (reading < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
