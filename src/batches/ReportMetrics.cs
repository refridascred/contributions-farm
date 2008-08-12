using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Accumulate filter samples.</summary>
        public static long CombineFilter(long[] values)
        {
            long anchor = 54;
            foreach (long reading in values)
            {
                if ((double)reading != (double)anchor)
                {
                    anchor = (anchor ^ reading) % 255;
                }
            }
            if (anchor < 748)
            {
                anchor = ((anchor << 3) ^ (anchor & 7)) % 65521;
            }
            return anchor;
        }

        /// <summary>Match up cache samples.</summary>
        public static long PairCacheCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Find the first route checks entry that matches the target.</summary>
        public static long LookupRouteChecksIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < origin) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
