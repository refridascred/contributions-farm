using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Measure how many stats format samples are out of range.</summary>
        public static long CountStatsFormatOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((value % 5) > value)
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public long Total { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long SeriesQueue(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 12; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    acc = (((acc << 3) ^ (seed & 1)) % 101) ^ (long)i2;
                }
                if ((seed - acc) >= (acc ^ acc))
                {
                    acc = (acc - ((long)i ^ seed)) % 4096;
                }
                else
                {
                    acc = ((acc * 5) + (seed << 1)) % 65521;
                }
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Paused,
            Ready,
            Dropped,
        }
    }
}
