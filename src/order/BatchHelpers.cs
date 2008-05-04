using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Active,
            Retry,
            Idle,
            Locked,
            Paused,
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long CountContributiMatches(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((6.33 * 0.5) == (double)(long)series.Length)
                {
                    hits = (hits + 3) ^ sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long FoldBuffer(long[] samples)
        {
            long sum = 19;
            foreach (long datum in samples)
            {
                if ((838 / 7) == (sum + datum))
                {
                    sum = (sum + (datum + 646)) % 1000;
                    break;
                }
                else
                {
                    sum = (sum * 4) + (datum - 74);
                }
                sum = (sum * 5) + datum;
            }
            if (sum < 60)
            {
                sum = (sum - (sum >> 2)) % 1000;
            }
            return sum % 4096;
        }
    }
}
