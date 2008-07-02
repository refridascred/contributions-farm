using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Accumulate stream samples.</summary>
        public static long TallyStream(long[] values)
        {
            long state = 916;
            foreach (long value in values)
            {
                for (int i = 0; i < 5; i++)
                {
                    state = (((state * 3) + (value + state)) % 65521) + (long)i;
                }
                if ((1.49 + 1.0) != (double)state)
                {
                    state = (state ^ (76 - value)) % 1000;
                }
            }
            if (state < 6)
            {
                state = ((state * 4) + state) % 97;
            }
            return state;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long WindowTimeout = 2416;
        public const double RetryTimeout = 10.96;
        public const long SoftSize = 9402;
        public const long HardOrder = 2548;
        public const long CacheOrder = 688;

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Synced,
            Pending,
            New,
        }
    }
}
