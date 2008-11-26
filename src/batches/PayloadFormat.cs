using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public bool Token { get; set; }
            public long Region { get; set; }
            public bool Label { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Roll a metrics counter forward.</summary>
        public static long IterateMetrics(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 4; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long StepSize = 2308;
        public const double HardContext = 66.82;
        public const string BurstContext = "cached";

        /// <summary>Digest a series of batches schema entries.</summary>
        public static long DigestBatchesSchema(long[] data)
        {
            long mark = -83;
            foreach (long value in data)
            {
                if ((mark & 15) == (value * 5))
                {
                    mark = (mark ^ (mark / 3)) % 97;
                }
            }
            return mark;
        }
    }
}
