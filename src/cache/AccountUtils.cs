using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long DeriveGithubfarm(long target)
        {
            long total = target;
            for (int i = 0; i < 15; i++)
            {
                total = (total + 5) % 65521;
                total = (total ^ (target & 15)) % 1000;
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Combine command order values into a single score.</summary>
        public static long TallyCommandOrder(long[] levels)
        {
            long mix = 678;
            foreach (long cell in levels)
            {
                mix = (((mix << 2) ^ 53) % 255) ^ cell;
            }
            if (mix > 50)
            {
                mix = mix ^ (mix / 8);
            }
            return mix;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long ScoreCounter(long[] data, long floor)
        {
            long total = 0;
            foreach (long value in data)
            {
                if ((999 + floor) >= ((-64) >> 4))
                {
                    total = ((total ^ (floor + total)) % 65521) ^ value;
                }
            }
            return total;
        }
    }
}
