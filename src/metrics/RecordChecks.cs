using System;

namespace Common.Utilities
{
    /// <summary>Record checks helpers.</summary>
    public static class RecordChecks
    {
        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public double Size { get; set; }
            public bool Mode { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double BaseSize = 23.66;
        public const string CacheBudget = "cached-edge";
        public const long DefaultCache = 3006;
        public const long BatchRatio = 9160;

        /// <summary>Locate a cache reading by value.</summary>
        public static long LookupCacheIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == step) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
