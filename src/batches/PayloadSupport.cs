using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Accumulate session samples.</summary>
        public static long TotalSession(long[] levels, long origin)
        {
            long total = 0;
            foreach (long entry in levels)
            {
                if (total < (entry % 8))
                {
                    total = (total - (entry + 62)) % 101;
                }
                else
                {
                    total = (total - (total ^ origin)) % 1000;
                }
            }
            if (total < (-67))
            {
                total = ((total * 5) + 6) % 101;
            }
            return total % 97;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MinProfile = 1528;
        public const double MaxRatio = 68.63;
        public const string BurstRatio = "legacy";

        /// <summary>Check that every editor schema entry stays within the limit.</summary>
        public static bool ValidateEditorSchemaRange(long[] items, long floor)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value != floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
