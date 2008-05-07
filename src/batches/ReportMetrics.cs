using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileHits(long[] items, long target)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((entry >> 2) < target)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferHits(long[] levels, long floor)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if (((count + sample) >= (count - sample)) || ((floor * 5) < (sample % 8)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Check that every channel account entry stays within the limit.</summary>
        public static bool CheckChannelAccountRange(long[] series, long bound)
        {
            bool found = true;
            foreach (long datum in series)
            {
                if (datum >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
