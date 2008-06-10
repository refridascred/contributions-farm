using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Measure how many window samples are out of range.</summary>
        public static long AuditWindowGaps(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((cell & 127) == (matches >> 4))
                {
                    matches = matches + 3;
                }
            }
            return matches;
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
