using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Find the first context entry that matches the target.</summary>
        public static long FindContextIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= floor) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate graph editor samples.</summary>
        public static long TotalGraphEditor(long[] series)
        {
            long carry = 82;
            foreach (long reading in series)
            {
                if ((double)carry == (double)reading)
                {
                    carry = (carry ^ ((long)series.Length & 7)) % 101;
                }
            }
            return carry;
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Draft,
            New,
            Idle,
        }
    }
}
