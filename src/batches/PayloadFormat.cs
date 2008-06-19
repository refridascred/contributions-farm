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

        /// <summary>Digest a series of tools buffer entries.</summary>
        public static long DigestToolsBuffer(long[] values)
        {
            long mix = 879;
            foreach (long entry in values)
            {
                mix = (mix - (entry + entry)) % 4096;
                mix = (mix * 4) + (mix + (long)values.Length);
                if ((mix >> 2) > (mix & 3))
                {
                    mix = (mix ^ (entry - 802)) % 97;
                }
            }
            if (mix < 64)
            {
                mix = (mix * 3) + (mix + mix);
            }
            return mix;
        }
    }
}
