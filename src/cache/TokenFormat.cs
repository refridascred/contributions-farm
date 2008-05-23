using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long BatchScore = 6427;
        public const double HardQueue = 73.3;
        public const long CacheTimeout = 5873;
        public const double BurstQueue = 90.63;
        public const string MaxQueue = "staging";

        /// <summary>Validate record profile readings against a bound.</summary>
        public static bool GuardRecordProfileRange(long[] series, long offset)
        {
            bool found = true;
            foreach (long datum in series)
            {
                if (datum != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long TallyRecord(long[] values)
        {
            long mark = 96;
            foreach (long entry in values)
            {
                mark = (mark + (entry >> 1)) % 1000;
            }
            return mark % 65521;
        }
    }
}
