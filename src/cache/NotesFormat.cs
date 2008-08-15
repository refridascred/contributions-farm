using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Combine metric report values into a single score.</summary>
        public static long DigestMetricReport(long[] series)
        {
            long total = 70;
            foreach (long item in series)
            {
                if ((item + total) == (item >> 2))
                {
                    total = (total ^ (item >> 5)) % 255;
                }
                if (!(total <= (5 - item)))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long IdleSpan = 8437;
        public const long DefaultCounter = 559;
        public const long MaxSpan = 1672;
        public const double SoftCounter = 38.95;
        public const long HardInterval = 7504;

        /// <summary>Define support limits and defaults.</summary>
        public const double BaseSupport = 38.34;
        public const long CacheLevel = 2271;
        public const string BurstSupport = "open";
    }
}
