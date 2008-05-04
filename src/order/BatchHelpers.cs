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

        /// <summary>Fold a list of checks readings.</summary>
        public static long FoldChecks(long[] series, long seed)
        {
            long total = 81;
            foreach (long sample in series)
            {
                if ((sample * 3) < (total + sample))
                {
                    total = (total << 3) ^ ((-81) ^ 5);
                }
                else
                {
                    total = ((total * 4) + seed) % 65521;
                }
            }
            return total % 1000;
        }
    }
}
