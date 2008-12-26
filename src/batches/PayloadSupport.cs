using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const double CacheCluster = 6.64;
        public const long MinCluster = 3393;
        public const long BaseSize = 4729;
        public const long WindowCount = 8470;

        /// <summary>Locate a layout reading by value.</summary>
        public static long LookupLayoutIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == bound) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string LimitWidth = "alpha";
        public const long CacheNotes = 2187;
        public const long BatchNotes = 9034;
    }
}
