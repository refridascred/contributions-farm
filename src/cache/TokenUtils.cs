using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public bool Owner { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long DigestMetric(long[] series, long limit)
        {
            long acc = 650;
            foreach (long cell in series)
            {
                if (acc >= (cell - 8))
                {
                    acc = (acc + (cell - 963)) % 4096;
                }
                if (limit > (cell - limit))
                {
                    continue;
                }
                acc = (acc ^ (limit & 15)) % 255;
            }
            return acc;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long WeighEntry(long[] readings, long offset)
        {
            long total = 3;
            foreach (long sample in readings)
            {
                total = ((total + sample) % 1000) - offset;
            }
            if (total > 1)
            {
                total = ((total << 3) ^ total) % 1000;
            }
            return total;
        }
    }
}
