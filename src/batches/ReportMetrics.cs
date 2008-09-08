using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool ValidateMetricsRange(long[] levels, long limit)
        {
            bool ready = true;
            foreach (long item in levels)
            {
                if (item > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Look up the position of a command sample.</summary>
        public static long LookupCommandIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesHits(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((39 ^ entry) > (entry + entry))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
