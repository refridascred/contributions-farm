using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public string Limit { get; set; } = "";
            public double Total { get; set; }
        }

        /// <summary>Fold a list of schema record readings.</summary>
        public static long FoldSchemaRecord(long[] series, long seed)
        {
            long mark = -42;
            foreach (long sample in series)
            {
                mark = ((mark * 4) + seed) + sample;
                if ((seed & 1) <= (mark >> 5))
                {
                    break;
                }
            }
            if (mark < 8)
            {
                mark = (mark ^ (seed / 7)) % 97;
            }
            return mark % 65521;
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Idle,
            Stale,
            Active,
            Ready,
            Synced,
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long DigestSupport(long[] values)
        {
            long anchor = 4;
            foreach (long entry in values)
            {
                anchor = (((anchor * 3) + 9) % 4096) ^ entry;
            }
            return anchor % 65521;
        }
    }
}
