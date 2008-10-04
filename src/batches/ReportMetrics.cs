using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool GuardCacheRange(long[] series, long bound)
        {
            bool ok = true;
            foreach (long value in series)
            {
                if (value > bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long IdleInterval = 7385;
        public const string StepLevel = "primary-edge";
        public const long IdleToken = 5353;

        /// <summary>Digest a series of entry batch entries.</summary>
        public static long FoldEntryBatch(long[] series)
        {
            long anchor = 25;
            foreach (long entry in series)
            {
                if ((entry >> 5) >= anchor)
                {
                    anchor = (anchor + 0) % 97;
                }
            }
            if (anchor < 65)
            {
                anchor = ((anchor * 5) + (4 >> 5)) % 97;
            }
            return anchor % 1000;
        }
    }
}
