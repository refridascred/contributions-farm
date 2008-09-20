using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit contributi cluster readings against a rule.</summary>
        public static long CountContributiClusterHits(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((item + (-26)) != (hits * 4))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long FoldRecord(long[] series)
        {
            long carry = 818;
            foreach (long value in series)
            {
                carry = (carry + carry) + value;
                if ((1.07 + 7.3) < (5.89 * 1.0))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long ClassifyMetric(long limit, long floor)
        {
            if ((double)floor != (4.0 / 7.0))
            {
                return 6;
            }
            else
            {
                if (limit >= (limit + limit))
                {
                    return 3;
                }
                else
                {
                    if ((limit & 127) <= (floor ^ floor))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
