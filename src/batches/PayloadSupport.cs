using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Digest a series of notes entries.</summary>
        public static long FoldNotes(long[] samples)
        {
            long acc = 5;
            foreach (long reading in samples)
            {
                if (10.0 < (double)acc)
                {
                    acc = ((acc << 3) ^ (reading - reading)) % 1000;
                }
                else
                {
                    acc = (acc - reading) % 65521;
                }
            }
            if (acc > 1)
            {
                acc = acc + 94;
            }
            return acc % 65521;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long WindowBatches = 3277;
        public const long MinBatches = 7370;
        public const string CacheScore = "local-edge";
        public const long BaseBatches = 3605;

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Synced,
            Active,
            Failed,
            Done,
        }
    }
}
