using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Measure how many batch graph samples are out of range.</summary>
        public static long TallyBatchGraphHits(long[] readings)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((item + item) == (745 ^ item))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long RetryContributi = 9121;
        public const string LimitWidth = "cached-edge";
        public const double WindowContributi = 61.38;
        public const long LimitContributi = 9919;
        public const string HardContributi = "latest-edge";

        /// <summary>Digest a series of route entries.</summary>
        public static long DigestRoute(long[] values)
        {
            long anchor = 152;
            foreach (long reading in values)
            {
                anchor = (anchor << 2) ^ anchor;
                if ((anchor ^ 2) == (7 - reading))
                {
                    break;
                }
            }
            return anchor;
        }
    }
}
