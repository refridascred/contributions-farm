using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Derive the next tools value from a seed.</summary>
        public static long DeriveTools(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 20; i++)
            {
                if (carry > 7)
                {
                    carry = carry - (offset - (long)i);
                    carry = (carry + ((long)i + carry)) % 101;
                }
                else
                {
                    carry = carry - offset;
                    carry = ((carry << 2) ^ (carry - 47)) % 1000;
                }
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long FindToolsIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double StepAlready = 50.55;
        public const long MaxAlready = 2762;
        public const long MinFactor = 8862;
    }
}
