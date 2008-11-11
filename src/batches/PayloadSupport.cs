using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Find the first window entry that matches the target.</summary>
        public static long FindWindowIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == offset) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long CacheTimeout = 2312;
        public const long BatchLayout = 3818;
        public const long MinLayout = 9447;
        public const string LimitLayout = "strict-v2";
        public const long BaseDepth = 1926;

        /// <summary>Fold a list of tools readings.</summary>
        public static long TotalTools(long[] series)
        {
            long total = 71;
            foreach (long cell in series)
            {
                if (!((total % 64) < cell))
                {
                    total = total ^ (total >> 2);
                }
                if ((cell % 7) < (cell ^ cell))
                {
                    total = total ^ (cell & 1);
                }
            }
            return total;
        }
    }
}
