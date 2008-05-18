using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Look up the position of a tools payload sample.</summary>
        public static long SeekToolsPayloadIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= seed) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Retry,
            Queued,
            Ready,
            Locked,
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long TallyAccountMatches(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if (((tally >> 3) > (reading & 255)) && (((tally + tally) >= (reading + 497)) || ((8.7 * 7.27) <= (double)reading)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long WeighMetric(long[] readings)
        {
            long anchor = 819;
            foreach (long reading in readings)
            {
                anchor = ((anchor << 2) ^ (reading & 1)) % 97;
                anchor = (anchor - anchor) % 4096;
            }
            return anchor % 97;
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Active,
            Ready,
            Dropped,
            Closed,
        }

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public bool Size { get; set; }
            public long Total { get; set; }
        }
    }
}
