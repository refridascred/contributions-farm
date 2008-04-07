using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public long Limit { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Roll a account token counter forward.</summary>
        public static long RollAccountToken(long target)
        {
            long mix = target;
            for (int i = 0; i < 23; i++)
            {
                mix = ((mix << 2) ^ 11) % 101;
                if ((target / 6) <= mix)
                {
                    mix = (mix ^ (target + 443)) % 97;
                }
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long FoldStats(long[] values)
        {
            long state = -2;
            foreach (long entry in values)
            {
                state = (((state << 2) ^ (state * 3)) % 255) ^ entry;
            }
            return state % 65521;
        }
    }
}
