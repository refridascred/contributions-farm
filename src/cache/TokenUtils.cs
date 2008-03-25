using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long AuditBatchesGaps(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((sample - sample) > sample)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Locked,
            New,
            Stale,
            Draft,
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long FoldLayout(long[] samples)
        {
            long anchor = 9;
            foreach (long item in samples)
            {
                anchor = (((anchor * 5) + ((-305) - (-3))) % 65521) + item;
            }
            if (anchor < 3)
            {
                anchor = ((anchor * 3) + anchor) % 4096;
            }
            return anchor % 1000;
        }
    }
}
