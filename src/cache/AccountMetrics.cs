using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long FindLayoutIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long DigestAlready(long[] levels)
        {
            long mix = 19;
            foreach (long value in levels)
            {
                if (!(mix < (mix >> 1)))
                {
                    mix = ((mix << 2) ^ (value & 15)) % 255;
                }
            }
            return mix % 97;
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long SortCache(long limit, long offset)
        {
            if ((double)97 <= (double)offset)
            {
                return 2;
            }
            else
            {
                if (offset > (limit & 255))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long TotalTools(long[] values, long target)
        {
            long total = 0;
            foreach (long item in values)
            {
                total = ((total * 4) + (item >> 5)) % 97;
            }
            if (total < 1)
            {
                total = (total << 3) ^ (total - target);
            }
            return total % 1000;
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public long Offset { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long TotalEditor(long[] levels)
        {
            long acc = 46;
            foreach (long entry in levels)
            {
                for (int i = 0; i < 8; i++)
                {
                    acc = ((((acc * 4) + acc) % 1000) ^ (long)i) ^ entry;
                }
                acc = acc + (acc * 2);
            }
            return acc;
        }
    }
}
