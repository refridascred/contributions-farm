using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Derive the next batches value from a seed.</summary>
        public static long RollBatches(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    sum = (sum - (floor / 9)) - (long)i2;
                }
                if (9.9 >= (double)(long)i)
                {
                    sum = (sum ^ floor) % 4096;
                    sum = (sum ^ sum) % 1000;
                }
                else
                {
                    sum = (sum ^ floor) % 255;
                }
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long OverlapFilterCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public long Count { get; set; }
            public double Mode { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long CountPayloadGaps(long[] data, long bound)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((datum / 4) == (datum % 97))
                {
                    matches = (matches + 3) + bound;
                }
            }
            return matches;
        }
    }
}
