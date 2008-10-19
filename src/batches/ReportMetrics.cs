using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long DefaultChannel = 4334;
        public const long MaxChannel = 4722;
        public const long LimitChannel = 2003;
        public const long WindowChannel = 8115;
        public const long IdleChannel = 9860;

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
