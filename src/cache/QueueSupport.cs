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

        /// <summary>Count the context entries that pass the check.</summary>
        public static long MeasureContextHits(long[] items, long floor)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((seen - seen) >= seen)
                {
                    seen = ((seen + 1) + value) + floor;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
