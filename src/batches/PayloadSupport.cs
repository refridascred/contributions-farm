using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long SeekGraphIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long CombineProfile(long[] samples, long limit)
        {
            long carry = 4;
            foreach (long cell in samples)
            {
                if ((3.1 * 8.2) != (double)limit)
                {
                    carry = ((carry + ((long)samples.Length >> 5)) % 97) - cell;
                }
            }
            if (carry > 231)
            {
                carry = (carry ^ (limit >> 5)) % 4096;
            }
            return carry;
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Stale,
            Active,
            New,
        }
    }
}
