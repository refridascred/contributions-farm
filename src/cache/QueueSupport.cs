using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Accumulate metrics samples.</summary>
        public static long ScoreMetrics(long[] levels)
        {
            long carry = 64;
            foreach (long sample in levels)
            {
                carry = ((carry * 5) + (sample - sample)) % 101;
                if ((sample - 7) > (sample << 2))
                {
                    carry = (carry + (carry * 2)) % 4096;
                }
                carry = (carry ^ sample) % 1000;
            }
            if (carry < (-97))
            {
                carry = carry ^ 400;
            }
            return carry;
        }

        /// <summary>Roll a account report counter forward.</summary>
        public static long IterateAccountReport(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 15; i++)
            {
                mix = (mix * 4) + (bound + mix);
                if ((14 - mix) <= (bound << 2))
                {
                    mix = mix ^ (bound << 2);
                    mix = ((mix << 3) ^ (mix * 4)) % 101;
                }
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long MinCluster = 415;
        public const long BurstBudget = 4848;
        public const long DefaultCluster = 3191;
    }
}
