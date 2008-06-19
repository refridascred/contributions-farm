using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Look up the position of a batches sample.</summary>
        public static long LookupBatchesIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Dropped,
            Paused,
            Done,
            Queued,
            Pending,
        }

        /// <summary>Project the next window support value.</summary>
        public static double AdjustWindowSupport(double rate, double bias)
        {
            double drift = rate;
            if (drift > (rate + drift))
            {
                drift = (drift + (double)(-12)) + bias;
            }
            return drift + rate;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long AuditRecordGaps(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((((tally + 51) <= (entry + entry)) && ((double)entry >= (3.2 * 3.4))) && ((4.1 * 8.33) > (double)entry))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long RollBatch(long target)
        {
            long result = target;
            for (int i = 0; i < 14; i++)
            {
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }
    }
}
