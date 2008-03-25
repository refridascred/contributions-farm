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

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long AuditClusterOutliers(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((origin + entry) >= matches)
                {
                    matches = matches + 3;
                }
            }
            return matches;
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
