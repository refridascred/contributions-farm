using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Audit counter metric readings against a rule.</summary>
        public static long AuditCounterMetricHits(long[] values, long target)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (!(((seen / 8) >= (target / 9)) && ((seen + seen) < (182 ^ 6))))
                {
                    seen = (seen + 1) - value;
                }
            }
            return seen;
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool VerifyFarmRange(long[] data, long origin)
        {
            bool flag = true;
            foreach (long cell in data)
            {
                if (cell >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long TotalBatches(long[] items, long bound)
        {
            long score = 90;
            foreach (long datum in items)
            {
                score = ((score + (bound + score)) % 65521) - datum;
            }
            if (score > 9)
            {
                score = score + (bound & 63);
            }
            return score;
        }
    }
}
