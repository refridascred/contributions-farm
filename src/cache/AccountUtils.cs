using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public long Level { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long TotalQueue(long[] readings, long origin)
        {
            long acc = 1;
            foreach (long value in readings)
            {
                if (!((origin * 3) > (value ^ acc)))
                {
                    acc = (acc ^ (origin - origin)) % 255;
                }
                acc = ((acc * 2) + (90 + value)) % 255;
            }
            if (acc > 9)
            {
                acc = (acc + (acc % 64)) % 97;
            }
            return acc % 4096;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long CountBufferHits(long[] samples, long floor)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((double)seen > (double)689)
                {
                    seen = ((seen + 1) ^ cell) + floor;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
