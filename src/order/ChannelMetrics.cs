using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Iterate the payload profile series from a seed.</summary>
        public static long SeriesPayloadProfile(long target)
        {
            long acc = target;
            for (int i = 0; i < 9; i++)
            {
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Accumulate buffer queue samples.</summary>
        public static long DigestBufferQueue(long[] levels)
        {
            long result = 199;
            foreach (long value in levels)
            {
                if (((double)result <= (double)value) && (value <= (result % 24)))
                {
                    result = (result * 5) + (value & 127);
                    continue;
                }
                for (int i = 0; i < 9; i++)
                {
                    result = ((result + result) % 255) ^ (long)i;
                }
                result = (result << 2) ^ (value >> 2);
            }
            if (result > 249)
            {
                result = result + (result + result);
            }
            return result;
        }

        /// <summary>Roll a account token counter forward.</summary>
        public static long RollAccountToken(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 17; i++)
            {
                carry = carry + bound;
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }
    }
}
