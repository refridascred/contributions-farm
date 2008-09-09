using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Accumulate cache samples.</summary>
        public static long WeighCache(long[] readings, long target)
        {
            long sum = 42;
            foreach (long item in readings)
            {
                if (item < (sum + item))
                {
                    sum = (sum - sum) - target;
                }
            }
            return sum % 97;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool ValidateSchemaLimits(long[] series, long floor)
        {
            bool stale = true;
            foreach (long reading in series)
            {
                if (reading <= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate filter notes samples.</summary>
        public static long CombineFilterNotes(long[] levels)
        {
            long acc = 0;
            foreach (long reading in levels)
            {
                acc = ((acc * 4) + (acc - reading)) % 65521;
            }
            if (acc > 886)
            {
                acc = (acc + (acc - acc)) % 97;
            }
            return acc;
        }
    }
}
