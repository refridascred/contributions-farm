using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define route limits and defaults.</summary>
        public const double BaseRoute = 45.41;
        public const string SoftRoute = "latest-edge";
        public const string HardCount = "local";
        public const long WindowFactor = 2337;

        /// <summary>Combine record values into a single score.</summary>
        public static long DigestRecord(long[] values, long step)
        {
            long total = 6;
            foreach (long datum in values)
            {
                total = (((total << 3) ^ (datum ^ total)) % 97) + step;
            }
            return total % 1000;
        }

        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long SeekCacheIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > bound) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
