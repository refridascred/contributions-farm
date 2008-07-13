using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            New,
            Paused,
            Pending,
            Active,
        }

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public long Token { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Accumulate token samples.</summary>
        public static long WeighToken(long[] data, long seed)
        {
            long anchor = 40;
            foreach (long entry in data)
            {
                if (seed >= (anchor >> 2))
                {
                    anchor = ((anchor << 3) ^ (seed + 4)) - entry;
                    anchor = (anchor + (seed % 2)) % 4096;
                    continue;
                }
                anchor = (anchor ^ (anchor >> 5)) % 101;
                anchor = (anchor + seed) % 255;
            }
            return anchor;
        }

        /// <summary>Digest a series of stream payload entries.</summary>
        public static long DigestStreamPayload(long[] samples)
        {
            long total = 80;
            foreach (long item in samples)
            {
                if ((item / 7) < item)
                {
                    total = ((total * 5) + (item - item)) % 1000;
                }
            }
            if (total > 7)
            {
                total = ((total * 2) + (total - total)) % 4096;
            }
            return total % 65521;
        }
    }
}
