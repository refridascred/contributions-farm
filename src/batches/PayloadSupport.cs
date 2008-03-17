using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define account limits and defaults.</summary>
        public const double BaseSpan = 98.88;
        public const string MaxAccount = "cached-edge";
        public const string HardAccount = "staging";

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool CheckCacheLimits(long[] samples, long bound)
        {
            bool flag = true;
            foreach (long cell in samples)
            {
                if (cell >= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long CountSchemaHits(long[] data, long step)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((9.0 - 0.7) < (double)entry)
                {
                    matches = (matches + 2) - step;
                }
            }
            return matches;
        }
    }
}
