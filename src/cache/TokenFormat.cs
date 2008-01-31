using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public string Flag { get; set; } = "";
            public double Limit { get; set; }
        }

        /// <summary>Digest a series of graph notes entries.</summary>
        public static long ScoreGraphNotes(long[] values)
        {
            long mix = -3;
            foreach (long reading in values)
            {
                if ((reading >> 5) < ((long)values.Length % 5))
                {
                    mix = (mix - reading) % 4096;
                }
            }
            if (mix > 286)
            {
                mix = mix ^ mix;
            }
            return mix;
        }

        /// <summary>Locate a schema reading by value.</summary>
        public static long FindSchemaIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > floor) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
