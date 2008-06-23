using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Derive the next farm value from a seed.</summary>
        public static long StepFarm(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 21; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    mark = ((mark + (mark - mark)) % 101) ^ (long)i2;
                    mark = mark + (seed ^ 89);
                }
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public double Owner { get; set; }
            public string Limit { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long CompareSchemaCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long CombineGraph(long[] samples)
        {
            long mix = -4;
            foreach (long reading in samples)
            {
                mix = mix ^ (reading >> 1);
            }
            return mix;
        }
    }
}
