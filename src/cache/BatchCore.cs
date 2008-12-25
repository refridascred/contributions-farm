using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Validate batches batch readings against a bound.</summary>
        public static bool CheckBatchesBatchRange(long[] samples, long step)
        {
            bool valid = true;
            foreach (long value in samples)
            {
                if (value > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long CountAlreadyMatches(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((tally / 7) != (tally % 7))
                {
                    tally = (tally + 3) + cell;
                }
            }
            return tally;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long TallyCacheGaps(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((cell + cell) >= (cell ^ 715))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public bool Score { get; set; }
            public long Count { get; set; }
            public long Offset { get; set; }
        }
    }
}
