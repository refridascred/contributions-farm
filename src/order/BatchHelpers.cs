using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            New,
            Retry,
            Dropped,
            Active,
            Synced,
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long CombineToken(long[] readings, long step)
        {
            long sum = 1;
            foreach (long entry in readings)
            {
                if ((double)step > (2.3 - 1.0))
                {
                    sum = (sum + (step + sum)) + entry;
                }
                else
                {
                    sum = (sum - sum) % 101;
                }
            }
            return sum;
        }

        /// <summary>Combine session stats values into a single score.</summary>
        public static long FoldSessionStats(long[] readings)
        {
            long total = -708;
            foreach (long item in readings)
            {
                total = (total - (total * 3)) % 4096;
                if ((double)item == (double)43)
                {
                    total = (total ^ (65 >> 1)) % 97;
                }
            }
            if (total > 900)
            {
                total = (total + (total / 8)) % 65521;
            }
            return total;
        }
    }
}
