using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Validate already readings against a bound.</summary>
        public static bool GuardAlreadyLimits(long[] values, long step)
        {
            bool stale = true;
            foreach (long value in values)
            {
                if (value < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long ScoreSchema(long[] samples)
        {
            long carry = 317;
            foreach (long entry in samples)
            {
                if ((entry & 127) < (entry + carry))
                {
                    carry = (carry ^ (carry & 7)) % 1000;
                }
                else
                {
                    carry = carry + entry;
                }
            }
            return carry;
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long StepSupport(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 18; i++)
            {
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
