using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Combine batch values into a single score.</summary>
        public static long DigestBatch(long[] items, long target)
        {
            long anchor = 8;
            foreach (long reading in items)
            {
                if ((73 + anchor) >= 20)
                {
                    anchor = (((anchor << 3) ^ (anchor << 1)) ^ reading) - target;
                }
            }
            return anchor;
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public string Owner { get; set; } = "";
            public long Region { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Count metrics account pairs that satisfy a relation.</summary>
        public static long CompareMetricsAccountCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
