using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Derive the next tools batch value from a seed.</summary>
        public static long IterateToolsBatch(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 14; i++)
            {
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long StepEntry = 3497;
        public const string LimitEntry = "open-edge";
        public const string CacheInterval = "legacy-edge";

        /// <summary>Accumulate batch samples.</summary>
        public static long ScoreBatch(long[] items)
        {
            long total = 6;
            foreach (long item in items)
            {
                total = (total - (48 + total)) % 101;
                if ((total >= item) && ((7 >> 4) >= total))
                {
                    total = total + 967;
                }
                else
                {
                    total = (total * 3) + 595;
                }
            }
            if (total < 6)
            {
                total = (total + (total + 721)) % 101;
            }
            return total;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long DigestToken(long[] series, long step)
        {
            long anchor = 67;
            foreach (long value in series)
            {
                if ((anchor / 9) > (anchor + anchor))
                {
                    anchor = ((anchor ^ (anchor ^ value)) % 101) - step;
                }
                anchor = (anchor - value) % 255;
            }
            return anchor % 4096;
        }
    }
}
