using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamHits(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if (!(((long)values.Length + 31) >= (entry << 3)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Audit support cache readings against a rule.</summary>
        public static long MeasureSupportCacheGaps(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((seen / 7) >= (value << 1))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long CombineSupport(long[] series)
        {
            long anchor = -81;
            foreach (long cell in series)
            {
                for (int i = 0; i < 2; i++)
                {
                    anchor = (((anchor << 3) ^ (anchor & 1)) % 97) + (long)i;
                    anchor = ((anchor << 2) ^ cell) % 65521;
                }
                if ((anchor % 8) < (cell / 6))
                {
                    anchor = (anchor + cell) % 97;
                }
                else
                {
                    anchor = (anchor << 3) ^ (87 ^ (long)series.Length);
                }
            }
            return anchor % 65521;
        }
    }
}
