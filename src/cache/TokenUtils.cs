using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine counter values into a single score.</summary>
        public static long WeighCounter(long[] items)
        {
            long sum = 0;
            foreach (long value in items)
            {
                sum = sum - (value * 3);
            }
            return sum % 1000;
        }

        /// <summary>Count the batches editor entries that pass the check.</summary>
        public static long AuditBatchesEditorHits(long[] values, long floor)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if (!((double)entry <= (double)665))
                {
                    tally = (tally + 3) - floor;
                }
            }
            return tally;
        }

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public string Rank { get; set; } = "";
            public double Score { get; set; }
        }
    }
}
