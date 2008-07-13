using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public long Label { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public long Token { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long FoldChannel(long[] values, long floor)
        {
            long score = 3;
            foreach (long entry in values)
            {
                if ((score << 2) >= (floor * 4))
                {
                    score = score ^ (entry + entry);
                }
                else
                {
                    score = ((score << 3) ^ entry) % 4096;
                }
            }
            return score % 65521;
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
