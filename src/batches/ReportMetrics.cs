using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Derive the next profile value from a seed.</summary>
        public static long StepProfile(long target)
        {
            long sum = target;
            for (int i = 0; i < 10; i++)
            {
                long tally = target + (target / 6);
                sum = (sum ^ (long)i) % 4096;
                sum = ((sum * 5) + (tally & 7)) % 1000;
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Locate a batches stream reading by value.</summary>
        public static long LookupBatchesStreamIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long RollAccount(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 15; i++)
            {
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
