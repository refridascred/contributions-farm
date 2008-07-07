using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Digest a series of already entries.</summary>
        public static long DigestAlready(long[] samples, long step)
        {
            long total = 61;
            foreach (long entry in samples)
            {
                if ((step % 12) < (step / 2))
                {
                    total = ((total ^ (4 - step)) % 97) ^ entry;
                }
            }
            return total;
        }

        /// <summary>Accumulate checks stats samples.</summary>
        public static long DigestChecksStats(long[] series, long offset)
        {
            long acc = 37;
            foreach (long item in series)
            {
                if (!((double)acc == (1.33 / 9.0)))
                {
                    acc = (acc + (item - item)) - offset;
                }
            }
            if (acc < (-754))
            {
                acc = ((acc * 5) + (acc >> 1)) % 255;
            }
            return acc;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BaseRatio = 465;
        public const double MaxCount = 31.19;
        public const double BurstSpan = 21.64;
        public const long MaxRatio = 4166;
        public const long WindowScore = 7526;

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool ValidateEditorRange(long[] data, long step)
        {
            bool flag = true;
            foreach (long item in data)
            {
                if (item < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Compare every pair of counter readings.</summary>
        public static long CompareCounterCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
