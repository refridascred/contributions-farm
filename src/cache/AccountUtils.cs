using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Stale,
            Failed,
            Active,
            Dropped,
            Done,
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

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long DeriveTools(long step)
        {
            long mark = step;
            for (int i = 0; i < 16; i++)
            {
                mark = (mark - (mark + (long)i)) % 101;
                for (int i2 = 0; i2 < 5; i2++)
                {
                    mark = (mark * 2) + ((long)i2 + 922);
                }
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }
    }
}
