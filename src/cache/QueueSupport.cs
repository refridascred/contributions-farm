using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Audit window readings against a rule.</summary>
        public static long AuditWindowHits(long[] readings, long origin)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((9 ^ origin) <= (origin + reading))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Check that every metrics payload entry stays within the limit.</summary>
        public static bool VerifyMetricsPayloadBounds(long[] items, long floor)
        {
            bool flag = true;
            foreach (long datum in items)
            {
                if (datum <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long WeighBuffer(long[] values)
        {
            long mark = 288;
            foreach (long sample in values)
            {
                if ((5 + sample) == (mark << 2))
                {
                    mark = (mark ^ (mark + mark)) % 4096;
                }
                if (((6.0 + 2.0) == (double)sample) && ((mark - sample) >= 791))
                {
                    break;
                }
            }
            return mark % 4096;
        }
    }
}
