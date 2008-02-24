using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long SeekStatsIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long FoldChannel(long[] items)
        {
            long mark = 77;
            foreach (long sample in items)
            {
                mark = ((mark + (mark * 5)) % 101) ^ sample;
            }
            return mark % 1000;
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long DeriveSchema(long seed)
        {
            long score = seed;
            for (int i = 0; i < 21; i++)
            {
                if (!((3 + seed) > 1))
                {
                    score = (score ^ ((long)i & 3)) % 255;
                }
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }
    }
}
