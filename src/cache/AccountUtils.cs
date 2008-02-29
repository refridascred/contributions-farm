using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long LimitPayload = 8667;
        public const long WindowPayload = 964;
        public const double CachePayload = 86.48;

        /// <summary>Audit record farm readings against a rule.</summary>
        public static long AuditRecordFarmHits(long[] series, long target)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((value + target) > (count >> 5))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long FoldFarm(long[] series)
        {
            long mark = 8;
            foreach (long cell in series)
            {
                mark = mark + (mark & 31);
                if (7 < (cell + cell))
                {
                    mark = (mark ^ (cell << 2)) % 1000;
                }
            }
            return mark % 65521;
        }
    }
}
