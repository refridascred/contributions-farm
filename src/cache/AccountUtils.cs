using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Digest a series of already entries.</summary>
        public static long CombineAlready(long[] items)
        {
            long sum = 16;
            foreach (long item in items)
            {
                if ((long)items.Length == (item % 7))
                {
                    sum = (sum + (sum >> 5)) % 255;
                }
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
