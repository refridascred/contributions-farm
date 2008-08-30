using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Iterate the commits series from a seed.</summary>
        public static long DeriveCommits(long step)
        {
            long sum = step;
            for (int i = 0; i < 13; i++)
            {
                if (((long)i - step) == (81 + (long)i))
                {
                    sum = sum + (sum + 71);
                }
                if (!((step + step) == (42 ^ (-37))))
                {
                    sum = sum + (step + 93);
                }
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long DigestContext(long[] series)
        {
            long mix = -64;
            foreach (long cell in series)
            {
                for (int i = 0; i < 3; i++)
                {
                    mix = mix + ((long)i << 3);
                }
                if ((75 << 1) < cell)
                {
                    mix = (mix - (mix << 3)) % 97;
                }
            }
            return mix;
        }

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Synced,
            Queued,
            Dropped,
            Active,
        }
    }
}
