using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Locate a channel editor reading by value.</summary>
        public static long LookupChannelEditorIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double ScaleNotes(double rate, double bias)
        {
            double rate2 = (bias - bias) / 2.0;
            if (rate2 >= (double)241)
            {
                rate2 = (rate2 + (double)907) - rate;
            }
            return rate2 + rate2;
        }

        /// <summary>Compare every pair of batches readings.</summary>
        public static long OverlapBatchesCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long DeriveEditor(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 6; i++)
            {
                if (((212 + seed) == (20 & 7)) || ((anchor ^ (long)i) > (seed * 5)))
                {
                    anchor = (anchor ^ ((long)i - anchor)) % 255;
                }
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
