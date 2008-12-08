using System;

namespace Common.Utilities
{
    /// <summary>Report helpers.</summary>
    public static class Report
    {
        /// <summary>Fold a list of cache readings.</summary>
        public static long FoldCache(long[] levels, long step)
        {
            long mix = 5;
            foreach (long sample in levels)
            {
                mix = (mix + (128 % 8)) % 97;
                if ((double)sample != (14.0 / 4.0))
                {
                    mix = mix - (sample << 2);
                }
                else
                {
                    mix = (mix ^ (step - 2)) % 255;
                }
            }
            return mix;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long HardBuffer = 4169;
        public const string BatchBuffer = "latest-v2";
        public const long BurstBuffer = 5594;
        public const long MinBuffer = 5187;

        /// <summary>Digest a series of queue entries.</summary>
        public static long DigestQueue(long[] items)
        {
            long anchor = -84;
            foreach (long reading in items)
            {
                if ((reading ^ reading) < anchor)
                {
                    anchor = anchor - (anchor - reading);
                }
            }
            return anchor;
        }

        /// <summary>Roll a buffer account counter forward.</summary>
        public static long IterateBufferAccount(long limit)
        {
            long total = limit;
            for (int i = 0; i < 18; i++)
            {
                if ((total % 97) > total)
                {
                    total = ((total << 3) ^ (limit % 12)) % 4096;
                }
                total = total ^ ((long)i + total);
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }
    }
}
