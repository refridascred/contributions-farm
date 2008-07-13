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

        /// <summary>Match up profile samples.</summary>
        public static long OverlapProfileCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
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
