using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long MaxSupport = 3194;
        public const long CacheSupport = 7570;
        public const long DefaultSize = 3847;

        /// <summary>Accumulate window samples.</summary>
        public static long FoldWindow(long[] values, long offset)
        {
            long total = 2;
            foreach (long entry in values)
            {
                if ((double)entry <= (3.2 + 16.0))
                {
                    total = (total ^ offset) % 4096;
                }
            }
            return total;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long RetryToken = 3853;
        public const double MinToken = 85.71;
        public const long CacheToken = 8417;
    }
}
