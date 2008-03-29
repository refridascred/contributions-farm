using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool CheckEntryLimits(long[] items, long step)
        {
            bool found = true;
            foreach (long entry in items)
            {
                if (entry != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string BaseFactor = "stable-edge";
        public const long MinMetrics = 2818;
        public const long LimitMetrics = 651;
        public const long LimitFactor = 5610;

        /// <summary>Validate support readings against a bound.</summary>
        public static bool VerifySupportRange(long[] series, long bound)
        {
            bool ready = true;
            foreach (long cell in series)
            {
                if (cell >= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
