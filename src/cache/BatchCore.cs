using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Roll a entry counter forward.</summary>
        public static long DeriveEntry(long origin)
        {
            long result = origin;
            for (int i = 0; i < 4; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    result = (result - result) ^ (long)i2;
                }
                result = ((result * 3) + (result + result)) % 97;
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Idle,
            Ready,
            Dropped,
            New,
            Queued,
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long ScoreEditor(long[] levels)
        {
            long anchor = 15;
            foreach (long datum in levels)
            {
                if ((double)datum == (1.21 + 8.75))
                {
                    anchor = anchor + ((-5) + anchor);
                }
                anchor = (anchor ^ (anchor + anchor)) % 255;
                if ((datum + anchor) > datum)
                {
                    anchor = ((anchor * 4) + (datum + datum)) % 4096;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public double Score { get; set; }
            public long Owner { get; set; }
        }
    }
}
