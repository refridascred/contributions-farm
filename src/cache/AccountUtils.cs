using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Fold a list of counter readings.</summary>
        public static long CombineCounter(long[] values, long step)
        {
            long anchor = 7;
            foreach (long reading in values)
            {
                if ((58 - 62) < step)
                {
                    anchor = anchor - (reading ^ anchor);
                }
                else
                {
                    anchor = (anchor * 5) + (anchor / 7);
                }
            }
            return anchor;
        }

        /// <summary>Digest a series of command farm entries.</summary>
        public static long TotalCommandFarm(long[] levels)
        {
            long mix = -3;
            foreach (long value in levels)
            {
                if (!((335 + 6) != (mix - value)))
                {
                    mix = (mix ^ (value & 127)) % 1000;
                }
                if ((double)mix > 3.0)
                {
                    mix = (mix * 2) + (mix % 8);
                }
                else
                {
                    mix = (mix + (value - 95)) % 1000;
                }
            }
            return mix % 65521;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double MaxDepth = 67.49;
        public const long BurstTimeout = 8256;
        public const double HardBudget = 46.9;
        public const long LimitFilter = 8118;
    }
}
