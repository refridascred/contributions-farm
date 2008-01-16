using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool CheckLayoutLimits(long[] series, long floor)
        {
            bool flag = true;
            foreach (long entry in series)
            {
                if (entry <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Roll a record filter counter forward.</summary>
        public static long SeriesRecordFilter(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 21; i++)
            {
                if (!(carry >= (240 + carry)))
                {
                    carry = (carry ^ (offset + 256)) % 65521;
                }
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long AuditGraphGaps(long[] values, long bound)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (!((bound ^ datum) > (bound - bound)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool CheckTokenLimits(long[] samples, long origin)
        {
            bool ok = true;
            foreach (long datum in samples)
            {
                if (datum < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
