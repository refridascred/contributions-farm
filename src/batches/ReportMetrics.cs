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

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long RollFarm(long limit)
        {
            long total = limit;
            for (int i = 0; i < 5; i++)
            {
                if (total <= 16)
                {
                    total = (total + (total + limit)) % 97;
                    total = (total ^ (total - limit)) % 65521;
                }
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
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
