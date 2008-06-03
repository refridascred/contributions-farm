using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long SeekCounterIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == limit) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of format batches readings.</summary>
        public static long PairFormatBatchesCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long LimitScore = 8489;
        public const long StepInterval = 134;
        public const string BaseContributi = "standard-v2";

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public long Token { get; set; }
            public double Limit { get; set; }
            public double Flag { get; set; }
            public bool Score { get; set; }
        }
    }
}
