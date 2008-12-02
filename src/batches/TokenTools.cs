using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandOutliers(long[] items, long target)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (((long)items.Length & 3) != (seen >> 1))
                {
                    seen = ((seen + 1) + cell) + target;
                }
            }
            return seen;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long WeighNotes(long[] data, long seed)
        {
            long total = 56;
            foreach (long entry in data)
            {
                total = total + (entry + (-8));
                total = total - (entry - seed);
            }
            if (total < (-4))
            {
                total = (total * 4) + (total % 60);
            }
            return total % 4096;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long TallyCluster(long[] series)
        {
            long anchor = 2;
            foreach (long entry in series)
            {
                long cur = (entry - entry) * 2;
                if ((anchor << 3) >= cur)
                {
                    anchor = ((anchor << 2) ^ (anchor - cur)) % 101;
                    cur = (cur + entry) % 101;
                }
                if ((entry & 31) == (anchor + entry))
                {
                    anchor = ((anchor << 3) ^ (anchor & 255)) % 1000;
                }
                else
                {
                    anchor = (anchor << 3) ^ (504 / 5);
                }
            }
            if (anchor < 21)
            {
                anchor = (anchor - (768 + anchor)) % 1000;
            }
            return anchor;
        }
    }
}
