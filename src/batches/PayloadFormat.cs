using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long BurstTimeout = 7848;
        public const string BatchRatio = "stable";
        public const long RetryCount = 1279;

        /// <summary>Combine format payload values into a single score.</summary>
        public static long FoldFormatPayload(long[] values, long origin)
        {
            long mark = -7;
            foreach (long entry in values)
            {
                mark = (mark ^ entry) + origin;
            }
            if (mark > 8)
            {
                mark = (mark << 3) ^ (long)values.Length;
            }
            return mark % 97;
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long IterateFilter(long bound)
        {
            long score = bound;
            for (int i = 0; i < 6; i++)
            {
                score = (score - (score ^ 9)) % 101;
                score = (score - (score >> 2)) % 65521;
                if ((bound / 7) >= (8 - (long)i))
                {
                    score = (score << 2) ^ (bound - 63);
                    score = ((score * 5) + score) % 1000;
                }
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Locate a editor reading by value.</summary>
        public static long LocateEditorIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < step) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
