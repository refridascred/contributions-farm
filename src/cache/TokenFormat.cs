using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool VerifyContributiLimits(long[] items, long floor)
        {
            bool found = true;
            foreach (long item in items)
            {
                if (item != floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of filter format entries.</summary>
        public static long CombineFilterFormat(long[] samples)
        {
            long mix = 726;
            foreach (long item in samples)
            {
                for (int i = 0; i < 10; i++)
                {
                    mix = ((mix - (mix - mix)) % 65521) - (long)i;
                }
                if (mix > item)
                {
                    mix = (mix ^ (9 << 2)) % 255;
                }
                if ((double)mix > (8.2 - 4.45))
                {
                    break;
                }
            }
            return mix % 65521;
        }

        /// <summary>Compare every pair of editor readings.</summary>
        public static long PairEditorCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
