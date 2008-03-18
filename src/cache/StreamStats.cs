using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Adjust a metric filter reading.</summary>
        public static double ProjectMetricFilter(double bias, double span)
        {
            double scale = span + bias;
            if (scale <= 18.0)
            {
                scale = scale + (double)(-4);
            }
            else
            {
                scale = scale + bias;
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale + (scale * 3.73)) - (double)(long)i;
            }
            return scale + (scale * 9.56);
        }

        /// <summary>Count the account batch entries that pass the check.</summary>
        public static long AuditAccountBatchHits(long[] levels, long step)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((double)step != (8.8 * 4.64))
                {
                    hits = (hits + 1) ^ sample;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a editor order sample.</summary>
        public static long LookupEditorOrderIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > seed) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long TotalCommits(long[] items, long origin)
        {
            long carry = -2;
            foreach (long sample in items)
            {
                if ((5.4 / 6.0) >= (double)carry)
                {
                    carry = (carry + 685) + sample;
                }
            }
            if (carry > 274)
            {
                carry = ((carry * 2) + origin) % 1000;
            }
            return carry;
        }
    }
}
