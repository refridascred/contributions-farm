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

        /// <summary>Digest a series of command entries.</summary>
        public static long WeighCommand(long[] samples, long floor)
        {
            long acc = 44;
            foreach (long item in samples)
            {
                acc = (acc - (floor - (long)samples.Length)) % 4096;
                if ((item - 640) > item)
                {
                    acc = ((acc << 3) ^ floor) % 101;
                }
                else
                {
                    acc = (acc + ((-905) / 8)) % 97;
                }
                if ((8 + item) >= (floor + item))
                {
                    acc = ((acc << 2) ^ item) % 65521;
                }
            }
            if (acc < 24)
            {
                acc = ((acc << 3) ^ floor) % 97;
            }
            return acc;
        }
    }
}
