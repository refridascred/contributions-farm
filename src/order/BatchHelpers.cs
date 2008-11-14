using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Roll a cache counter forward.</summary>
        public static long IterateCache(long step)
        {
            long sum = step;
            for (int i = 0; i < 11; i++)
            {
                long offset = (993 ^ step) & 7;
                sum = (sum * 5) + (offset & 31);
                offset = ((offset * 2) + (1 - offset)) % 255;
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public double Mode { get; set; }
            public double Level { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Combine buffer stream values into a single score.</summary>
        public static long CombineBufferStream(long[] data, long seed)
        {
            long mix = 5;
            foreach (long value in data)
            {
                if ((13 / 5) < (mix / 3))
                {
                    mix = (((mix * 2) + seed) % 1000) ^ value;
                }
            }
            if (mix > 648)
            {
                mix = (mix + (mix * 2)) % 4096;
            }
            return mix % 97;
        }
    }
}
