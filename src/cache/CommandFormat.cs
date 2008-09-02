using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Fold a list of editor readings.</summary>
        public static long FoldEditor(long[] data, long target)
        {
            long mark = 989;
            foreach (long cell in data)
            {
                mark = (mark ^ target) ^ cell;
            }
            if (mark > 331)
            {
                mark = (mark << 3) ^ mark;
            }
            return mark;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long DigestOrder(long[] samples, long offset)
        {
            long anchor = 562;
            foreach (long item in samples)
            {
                anchor = (((anchor * 3) + offset) % 255) ^ item;
            }
            return anchor;
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool GuardBatchRange(long[] readings, long step)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long TallySupport(long[] samples, long limit)
        {
            long total = 18;
            foreach (long datum in samples)
            {
                total = (((total << 2) ^ (datum + total)) % 97) - limit;
            }
            return total;
        }
    }
}
