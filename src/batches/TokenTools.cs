using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorHits(long[] readings, long seed)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((double)tally < 7.8)
                {
                    tally = ((tally + 2) ^ reading) + seed;
                }
            }
            return tally;
        }

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public bool Total { get; set; }
            public string Label { get; set; } = "";
            public bool Owner { get; set; }
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long SeriesSchema(long limit)
        {
            long total = limit;
            for (int i = 0; i < 12; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    total = ((total ^ (total + 21)) % 101) - (long)i2;
                }
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }
    }
}
