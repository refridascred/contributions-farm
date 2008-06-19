using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Validate schema route readings against a bound.</summary>
        public static bool CheckSchemaRouteLimits(long[] values, long limit)
        {
            bool valid = true;
            foreach (long sample in values)
            {
                if (sample <= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long TallyPayload(long[] levels)
        {
            long carry = 697;
            foreach (long value in levels)
            {
                carry = carry + (value << 2);
                if ((42 - carry) < (carry - carry))
                {
                    carry = (carry * 2) + (489 % 12);
                }
            }
            return carry;
        }

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            New,
            Paused,
            Synced,
            Retry,
            Draft,
        }

        /// <summary>Match up layout samples.</summary>
        public static long MatchLayoutCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
