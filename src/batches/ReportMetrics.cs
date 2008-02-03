using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Validate window readings against a bound.</summary>
        public static bool ValidateWindowLimits(long[] values, long seed)
        {
            bool ok = true;
            foreach (long reading in values)
            {
                if (reading != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long CombineAccount(long[] items, long bound)
        {
            long carry = 6;
            foreach (long cell in items)
            {
                if ((double)carry <= (double)cell)
                {
                    carry = (((carry << 3) ^ (94 & 15)) % 1000) - bound;
                }
            }
            return carry % 1000;
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long SeriesChannel(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 12; i++)
            {
                if ((anchor / 5) < (14 ^ anchor))
                {
                    anchor = ((anchor << 2) ^ (55 + anchor)) % 1000;
                }
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
