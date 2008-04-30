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

        /// <summary>Define notes limits and defaults.</summary>
        public const double IdleNotes = 24.59;
        public const string CacheNotes = "staging-v2";
        public const long BurstNotes = 6552;
        public const double BaseFactor = 8.53;

        /// <summary>Project the next command value.</summary>
        public static double BlendCommand(double gain, double span)
        {
            double ratio = (double)((-3) << 1);
            return ((ratio - (double)(-32)) + gain) + span;
        }
    }
}
