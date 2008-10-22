using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public double Level { get; set; }
            public long Total { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long MeasureContributiGaps(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (((value << 1) < (origin - matches)) || ((double)value == (4.9 * 9.0)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a format sample.</summary>
        public static long LookupFormatIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
