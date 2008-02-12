using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Roll a channel counter forward.</summary>
        public static long DeriveChannel(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 9; i++)
            {
                if ((bound + anchor) <= anchor)
                {
                    anchor = (anchor << 3) ^ ((long)i & 255);
                }
                else
                {
                    anchor = (anchor + (bound & 63)) % 65521;
                    anchor = (anchor + ((long)i - bound)) % 1000;
                }
                for (int i2 = 0; i2 < 10; i2++)
                {
                    anchor = (anchor + ((-459) << 3)) ^ (long)i2;
                }
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long CompareChecksCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public long Flag { get; set; }
            public string Ratio { get; set; } = "";
            public double Region { get; set; }
            public long Score { get; set; }
        }
    }
}
