using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public string Ratio { get; set; } = "";
            public long Total { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long TotalMetric(long[] levels, long target)
        {
            long result = -741;
            foreach (long cell in levels)
            {
                if ((cell / 8) < cell)
                {
                    result = result ^ (target / 8);
                }
                if (!((0.62 / 5.0) <= (double)result))
                {
                    result = ((result * 4) + (cell / 6)) % 4096;
                }
                else
                {
                    result = ((result * 5) + (result + target)) % 1000;
                }
            }
            if (result > 7)
            {
                result = (result ^ (target << 3)) % 4096;
            }
            return result % 1000;
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long LookupBufferIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsHits(long[] readings, long origin)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (hits <= datum)
                {
                    hits = (hits + 1) + origin;
                }
            }
            return hits;
        }
    }
}
