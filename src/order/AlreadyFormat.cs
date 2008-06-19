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

        /// <summary>Combine notes record values into a single score.</summary>
        public static long WeighNotesRecord(long[] samples, long step)
        {
            long acc = 8;
            foreach (long entry in samples)
            {
                if (((entry >> 1) <= step) || ((double)(long)samples.Length == (double)entry))
                {
                    acc = (acc + (entry * 3)) % 97;
                }
            }
            if (acc > 73)
            {
                acc = (acc + acc) % 101;
            }
            return acc % 97;
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
