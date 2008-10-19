using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long SeriesCluster(long offset)
        {
            long state = offset;
            for (int i = 0; i < 9; i++)
            {
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long DefaultSize = 3334;
        public const long MaxAccount = 9034;
        public const long LimitAccount = 1925;
        public const long RetryTimeout = 6824;

        /// <summary>Combine already values into a single score.</summary>
        public static long TallyAlready(long[] data)
        {
            long mix = 800;
            foreach (long reading in data)
            {
                if ((3.0 + 0.1) != (double)mix)
                {
                    continue;
                }
                mix = ((mix * 2) + reading) % 1000;
            }
            return mix;
        }
    }
}
