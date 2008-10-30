using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const string BatchSize = "fallback-edge";
        public const long MaxProfile = 8154;
        public const long LimitDepth = 8854;
        public const string MinProfile = "latest";

        /// <summary>Accumulate batch editor samples.</summary>
        public static long WeighBatchEditor(long[] levels)
        {
            long acc = 8;
            foreach (long reading in levels)
            {
                acc = (acc * 2) + (reading - reading);
            }
            if (acc < 649)
            {
                acc = (acc ^ acc) % 1000;
            }
            return acc % 97;
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool GuardSupportBounds(long[] data, long seed)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
