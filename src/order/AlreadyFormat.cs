using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Count the metric batches entries that pass the check.</summary>
        public static long MeasureMetricBatchesGaps(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if (!((cell / 8) == (count + cell)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool ValidateChecksRange(long[] series, long bound)
        {
            bool valid = true;
            foreach (long entry in series)
            {
                if (entry != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Active,
            Failed,
            New,
            Paused,
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Retry,
            Draft,
            Done,
            Locked,
            Queued,
        }

        /// <summary>Compare every pair of batches readings.</summary>
        public static long OverlapBatchesCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
