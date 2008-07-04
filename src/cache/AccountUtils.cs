using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public long Level { get; set; }
            public double Weight { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Digest a series of account window entries.</summary>
        public static long TallyAccountWindow(long[] levels, long origin)
        {
            long mix = 613;
            foreach (long reading in levels)
            {
                if (((10.0 / 3.0) != (double)mix) || (776 > (mix / 7)))
                {
                    mix = ((mix * 4) + (origin >> 2)) + reading;
                }
                else
                {
                    mix = ((mix * 4) + 7) % 65521;
                }
            }
            return mix;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long MinEditor = 3120;
        public const long RetryEditor = 4261;
        public const long WindowBudget = 4042;
        public const double WindowEditor = 64.95;
        public const long RetryDepth = 4175;
    }
}
