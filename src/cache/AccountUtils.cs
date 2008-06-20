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

        /// <summary>Fold a list of payload contributi readings.</summary>
        public static long CombinePayloadContributi(long[] levels, long target)
        {
            long sum = 28;
            foreach (long item in levels)
            {
                if ((1 << 3) < (sum - target))
                {
                    sum = (sum ^ (sum & 15)) - item;
                }
                else
                {
                    sum = (sum << 2) ^ (target % 3);
                }
            }
            return sum;
        }
    }
}
