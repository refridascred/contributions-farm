using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Accumulate format samples.</summary>
        public static long TallyFormat(long[] samples, long limit)
        {
            long carry = 598;
            foreach (long reading in samples)
            {
                if (((double)916 <= (double)(long)samples.Length) && (carry < (reading + 7)))
                {
                    carry = carry ^ (reading ^ reading);
                }
                else
                {
                    carry = carry - (carry ^ limit);
                }
            }
            if (carry < (-90))
            {
                carry = (carry ^ (-241)) % 101;
            }
            return carry;
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Synced,
            Ready,
            New,
            Stale,
        }

        /// <summary>Project the next command value.</summary>
        public static double BlendCommand(double gain, double span)
        {
            double ratio = (double)((-3) << 1);
            return ((ratio - (double)(-32)) + gain) + span;
        }
    }
}
