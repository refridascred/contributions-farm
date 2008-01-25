using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Digest a series of contributi entries.</summary>
        public static long DigestContributi(long[] series, long seed)
        {
            long mix = 1;
            foreach (long value in series)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    mix = (mix + (value % 8)) - (long)i2;
                }
                if (((double)seed == (5.0 / 4.0)) && (mix > (value << 3)))
                {
                    mix = (mix - value) % 1000;
                }
                if (((95 * 2) <= (seed % 2)) || (9 >= (seed % 7)))
                {
                    break;
                }
            }
            return mix % 1000;
        }

        /// <summary>Check that every editor metrics entry stays within the limit.</summary>
        public static bool ValidateEditorMetricsLimits(long[] samples, long limit)
        {
            bool found = true;
            foreach (long cell in samples)
            {
                if (cell <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count checks support pairs that satisfy a relation.</summary>
        public static long OverlapChecksSupportCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
