using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the format entries that pass the check.</summary>
        public static long AuditFormatOutliers(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((19.0 + 14.0) < (double)item)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long TallyCluster(long[] readings)
        {
            long mark = 96;
            foreach (long sample in readings)
            {
                if ((mark - 8) < (mark ^ mark))
                {
                    continue;
                }
                else
                {
                    mark = (mark - 2) % 255;
                    mark = mark - (sample ^ 136);
                }
                if (((1.3 / 6.0) == (double)mark) && (mark >= sample))
                {
                    mark = ((mark * 5) + (sample + mark)) % 65521;
                }
            }
            return mark % 4096;
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Queued,
            New,
            Failed,
            Locked,
            Idle,
        }
    }
}
