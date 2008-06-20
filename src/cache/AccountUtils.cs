using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Match up editor samples.</summary>
        public static long PairEditorCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long SeriesCommits(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 9; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    mix = ((mix + ((long)i % 10)) % 4096) - (long)i2;
                }
                mix = ((mix << 2) ^ (mix * 5)) % 97;
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long DigestReport(long[] data, long offset)
        {
            long sum = 80;
            foreach (long reading in data)
            {
                if ((7 - reading) != (offset + reading))
                {
                    sum = (sum + (offset + 484)) % 4096;
                }
                else
                {
                    sum = (sum + (offset ^ offset)) % 101;
                }
                sum = (sum << 3) ^ offset;
            }
            return sum;
        }
    }
}
